using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
using LIBSchool_FinalProjectBackEnd.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LIBSchool_FinalProjectBackEnd.Areas.LibAdmin.Controllers
{
    [Area("LibAdmin")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;

        public DashboardController(UserManager<AppUser>userManager,AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        [Authorize (Roles ="Admin,SuperAdmin")]

        public async Task<IActionResult> Index()
        {
            HomeVM home = new HomeVM
            {
                AppUsers = await _context.AppUsers.ToListAsync(),
                Orderses = await _context.Orders.ToListAsync(),
            };
            return View(home);
        }

        
    }
}
