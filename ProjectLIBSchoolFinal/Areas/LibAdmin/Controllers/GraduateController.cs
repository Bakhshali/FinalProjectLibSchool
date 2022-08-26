using LIBSchool_FinalProjectBackEnd.Areas.LibAdmin.Extensions;
using LIBSchool_FinalProjectBackEnd.Areas.LibAdmin.Utilities;
using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
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
    public class GraduateController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public GraduateController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            List<Graduate> graduate = await _context.Graduates.ToListAsync();
            return View(graduate.ToPagedList(page, 3));
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Country = await _context.Countries.ToListAsync();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Graduate graduate)
        {
            ViewBag.Country = await _context.Countries.ToListAsync();

            if (!ModelState.IsValid) return View();
            if (graduate.Photo != null)
            {
                if (!graduate.Photo.IsOkay(1))
                {
                    ModelState.AddModelError("Photo", "Seçdiyiniz şəkil düzgün formatda deyil(başqa şəkil seçin)!");
                    return View();
                }

                graduate.Image = await graduate.Photo.FileCreate(_environment.WebRootPath, @"assets\img\students\");
            }
            else
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil seçin*");
                return View();
            }

            await _context.Graduates.AddAsync(graduate);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            Graduate graduate = await _context.Graduates.FindAsync(id);
            if (graduate == null) return View();
            return View(graduate);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Graduate graduate = await _context.Graduates.FirstOrDefaultAsync(x => x.Id == id);
            ViewBag.Country = await _context.Countries.ToListAsync();
            if (graduate == null) return NotFound();
            return View(graduate);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(Graduate graduate, int id)
        {
            ViewBag.Country = await _context.Countries.ToListAsync();
            if (!ModelState.IsValid) return View();

            Graduate existedGraduate = await _context.Graduates.Include(c => c.Country).FirstOrDefaultAsync(x => x.Id == graduate.Id);
            if (existedGraduate == null) return NotFound();
            if (id != existedGraduate.Id) return BadRequest();
            existedGraduate.Name = graduate.Name;
            existedGraduate.Surname = graduate.Surname;
            existedGraduate.Position = graduate.Position;
            existedGraduate.Work = graduate.Work;
            existedGraduate.University = graduate.University;
            existedGraduate.Master = graduate.Master;
            existedGraduate.CountryId = graduate.CountryId;
            existedGraduate.IsChoose = graduate.IsChoose;

            //string path = Path.Combine(_environment.WebRootPath, @"assets\img\students", existedGraduate.Image);

            //if (System.IO.File.Exists(path))
            //{
            //    System.IO.File.Delete(path);
            //}

            if (graduate.Photo != null)
            {
                if (graduate.Photo.IsOkay(1))
                {
                    existedGraduate.Image = await graduate.Photo.FileCreate(_environment.WebRootPath, @"assets\img\students");
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
            Graduate graduate = await _context.Graduates.Include(c => c.Country).FirstOrDefaultAsync(c => c.Id == id);
            if (graduate == null) return NotFound();
            return View(graduate);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteGraduate(int id)
        {
            Graduate existedGraduate = await _context.Graduates.Include(c => c.Country).FirstOrDefaultAsync(c => c.Id == id);
            if (existedGraduate == null) return NotFound();

            string path = Path.Combine(_environment.WebRootPath, @"assets\img\students", existedGraduate.Image);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _context.Graduates.Remove(existedGraduate);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
