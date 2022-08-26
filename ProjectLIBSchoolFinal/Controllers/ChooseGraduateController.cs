using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
using LIBSchool_FinalProjectBackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIBSchool_FinalProjectBackEnd.Controllers
{
    public class ChooseGraduateController : Controller
    {
        private readonly AppDbContext _context;

        public ChooseGraduateController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
           List<Graduate> graduates = await _context.Graduates.Include(c=>c.Country).ToListAsync();
            return View(graduates);
        }
    }
}
