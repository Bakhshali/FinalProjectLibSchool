using LIBSchool_FinalProjectBackEnd.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectLIBSchoolFinal.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using X.PagedList;

namespace ProjectLIBSchoolFinal.Areas.LibAdmin.Controllers
{
    [Area("LibAdmin")]
    public class OnlineExamController : Controller
    {
        private readonly AppDbContext _context;

        public OnlineExamController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            List<OnlineExam> onlineExams = await _context.onlineExams.ToListAsync();
            return View(onlineExams.ToPagedList(page, 5));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(List<OnlineExam> questions, int id)
        {
            foreach (var item in questions)
            {
                OnlineExam question = new OnlineExam
                {
                    Question = item.Question,
                    option1 = item.option1,
                    option2 = item.option2,
                    option3 = item.option3,
                    option4 = item.option4,
                    Correct = item.Correct
                };
                _context.onlineExams.Add(question);
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Detail(int id)
        {
            OnlineExam onlineExams = await _context.onlineExams.FindAsync(id);
            if (onlineExams == null) return NotFound();
            return View(onlineExams);
        }

        public async Task<IActionResult> Delete(int id)
        {
            OnlineExam onlineExams = await _context.onlineExams.FindAsync(id);
            if (onlineExams == null) return NotFound();
            return View(onlineExams);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteQuestion(int id)
        {
            OnlineExam existedExam = await _context.onlineExams.FirstOrDefaultAsync(d => d.Qid == id);

            if (existedExam == null) return NotFound();

            _context.Remove(existedExam);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
