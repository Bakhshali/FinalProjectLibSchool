using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
using LIBSchool_FinalProjectBackEnd.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBSchool_FinalProjectBackEnd.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrderController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            OrderVM model = new OrderVM
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                BasketItems = _context.BasketItems.Include(b => b.Course).ThenInclude(f => f.Discount).Where(b => b.AppUserId == user.Id).ToList()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(OrderVM orderVM)
        {
            Course course = await _context.Courses.FirstOrDefaultAsync();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            OrderVM model = new OrderVM
            {
                Name = orderVM.Name,
                Surname = orderVM.Surname,
                Email = orderVM.Email,
                BasketItems = _context.BasketItems.Include(b => b.Course).ThenInclude(f => f.Discount).Where(b => b.AppUserId == user.Id).ToList()
            };

            if (!ModelState.IsValid) return View(model);

            if (model.BasketItems.Count == 0) return RedirectToAction("index", "home");
            Order order = new Order
            {
                Subject = orderVM.Subject,
                Location = orderVM.Location,
                Phone = orderVM.Phone,
                TotalPrice = 0,
                Date = DateTime.Now,
                AppUserId = user.Id
            };
            foreach (BasketItem item in model.BasketItems)
            {
                order.TotalPrice += item.Count * @Math.Ceiling(@item.Course.Price - (item.Course.Price * item.Course.Discount.Percent / 100));
                OrderItem orderItem = new OrderItem
                {
                    Name = item.Course.Name,
                    Price = @Math.Ceiling(@item.Course.Price - (item.Course.Price * item.Course.Discount.Percent / 100)),
                    AppUserId = user.Id,
                    CourseId = item.Course.Id,
                    Order = order
                };
                _context.OrderItems.Add(orderItem);
            }
            _context.BasketItems.RemoveRange(model.BasketItems);
            _context.Orders.Add(order);
            _context.SaveChanges();

            TempData["Ordered"] = true;

            return RedirectToAction("index", "home");
        }
    }
}
