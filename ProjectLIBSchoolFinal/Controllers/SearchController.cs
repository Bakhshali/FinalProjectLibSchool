using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
using LIBSchool_FinalProjectBackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBSchool_FinalProjectBackEnd.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;

        public SearchController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchCourse)
        {
            ViewBag.Search = searchCourse;

            ViewBag.FilterName = await _context.Courses.ToListAsync();
            //ViewBag.Course = await _context.Courses.Where(c => c.Name.Contains(searchCourse)).FirstOrDefaultAsync(c=>c.Name==); 

            List<Course> courses = await _context.Courses.Include(c=>c.Discount).Where(c => c.Name.Contains(searchCourse)).ToListAsync();

            List<Category> categories = await _context.Categories.ToListAsync();

            HomeVM model = new HomeVM
            {
                Branches = await _context.Branches.ToListAsync(),
                Courses = courses,
                Categories = categories,
                CourseEducations = await _context.CourseEducations.ToListAsync(),

            };
            return View(model);
        }
    }
}
