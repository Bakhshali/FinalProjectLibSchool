using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
using LIBSchool_FinalProjectBackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LIBSchool_FinalProjectBackEnd.Areas.LibAdmin.Controllers
{
    [Area("LibAdmin")]
    public class CheckoutController : Controller
    {
        private readonly AppDbContext _context;

        public CheckoutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page=1)
        {
            List<Order> orders = _context.Orders.Include(c=>c.AppUser).ToList();
            return View(orders.ToPagedList(page, 5));
        }

    }
}
