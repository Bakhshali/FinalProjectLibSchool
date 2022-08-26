using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
using LIBSchool_FinalProjectBackEnd.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBSchool_FinalProjectBackEnd.Controllers
{
    public class QuizController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public QuizController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [Authorize]
        public async Task<IActionResult> QuizProses()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return RedirectToAction("login", "account");
            }
            HomeVM model = new HomeVM
            {
               onlineExams = await _context.onlineExams.ToListAsync(),
            };

            return View(model);
        }
    }
}
