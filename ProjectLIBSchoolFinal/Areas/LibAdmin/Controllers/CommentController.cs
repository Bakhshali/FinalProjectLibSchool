using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using X.PagedList;

namespace LIBSchool_FinalProjectBackEnd.Areas.LibAdmin.Controllers
{
    [Area("LibAdmin")]
    public class CommentController : Controller
    {
        private readonly AppDbContext _context;

        public CommentController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page=1)
        {
            List<Comment> comments = await _context.Comments.Include(c=>c.AppUser).ToListAsync();
            return View(comments.ToPagedList(page, 5));
        }

        public async Task<IActionResult> Edit(int id)
        {
            Comment comment = await _context.Comments.Include(c=>c.AppUser).FirstOrDefaultAsync(c=>c.Id==id);
            return View(comment);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Comment comment)
        {
            if (!ModelState.IsValid) return View();

            Comment existedComment = await _context.Comments.FirstOrDefaultAsync(s => s.Id == comment.Id);
            if (existedComment == null) return NotFound();
            existedComment.Subject = comment.Subject;
            existedComment.Status = comment.Status;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
    }
}
