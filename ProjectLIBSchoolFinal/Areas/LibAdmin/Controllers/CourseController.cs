using LIBSchool_FinalProjectBackEnd.Areas.LibAdmin.Extensions;
using LIBSchool_FinalProjectBackEnd.Areas.LibAdmin.Utilities;
using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
using LIBSchool_FinalProjectBackEnd.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using X.PagedList;

namespace LIBSchool_FinalProjectBackEnd.Areas.LibAdmin.Controllers
{
    [Area("LibAdmin")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CourseController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            List<Course> courses = await _context.Courses.Include(c => c.Discount).ToListAsync();
            return View(courses.ToPagedList(page, 3));
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.Discount = await _context.Discounts.ToListAsync();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Course course)
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.Discount = await _context.Discounts.ToListAsync();
            if (!ModelState.IsValid) return View();

            if (course.Photo != null)
            {
                if (!course.Photo.IsOkay(1))
                {
                    ModelState.AddModelError("Photo", "Seçdiyiniz şəkil düzgün formatda deyil(başqa şəkil seçin)!");
                    return View();
                }

                course.Image = await course.Photo.FileCreate(_env.WebRootPath, @"assets\img\courses\");
            }
            else
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil seçin*");
                return View();
            }

            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {

            Course course = await _context.Courses.Include(c => c.Discount).FirstOrDefaultAsync(c => c.Id == id);
            List<CourseEducation> courses = await _context.CourseEducations.ToListAsync();
            if (course == null) return NotFound();
            return View(course);
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.Discount = await _context.Discounts.ToListAsync();
            Course course = await _context.Courses.FindAsync(id);
            if (course == null) return NotFound();
            return View(course);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(Course course)
        {
            if (!ModelState.IsValid) return View();
            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.Discount = await _context.Discounts.ToListAsync();
            Course existedCourse = await _context.Courses.FirstOrDefaultAsync(c => c.Id == course.Id);

            if (existedCourse == null) return NotFound();

            existedCourse.Name = course.Name;
            existedCourse.SubName = course.SubName;
            existedCourse.Price = course.Price;
            existedCourse.CategoryId = course.CategoryId;
            existedCourse.DiscountId = course.DiscountId;
            existedCourse.BelongText = course.BelongText;
            existedCourse.BelongTitle = course.BelongTitle;
            existedCourse.Condition = course.Condition;
            existedCourse.İnformation = course.İnformation;

            //string path = Path.Combine(_env.WebRootPath, @"assets\img\courses", existedCourse.Image);

            //if (System.IO.File.Exists(path))
            //{
            //    System.IO.File.Delete(path);
            //}

            if (course.Photo != null)
            {
                if (course.Photo.IsOkay(1))
                {
                    existedCourse.Image = await course.Photo.FileCreate(_env.WebRootPath, @"assets\img\courses");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Seçdiyiniz şəkil düzgün formatda deyil(başqa şəkil seçin)!");
                    return View();
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            Course course = await _context.Courses.Include(c => c.Discount).FirstOrDefaultAsync(c => c.Id == id);
            if (course == null) return NotFound();
            return View(course);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteCourse(int id)
        {
            Course existedCourse = await _context.Courses.FirstOrDefaultAsync(d => d.Id == id);

            if (existedCourse == null) return NotFound();

            string path = Path.Combine(_env.WebRootPath, @"assets\img\courses", existedCourse.Image);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _context.Remove(existedCourse);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
