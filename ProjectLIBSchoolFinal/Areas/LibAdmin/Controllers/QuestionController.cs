using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBSchool_FinalProjectBackEnd.Areas.LibAdmin.Controllers
{
    [Area("LibAdmin")]
    public class QuestionController : Controller
    {
        private readonly AppDbContext _context;

        public QuestionController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Contact> contacts = await _context.Contacts.ToListAsync();
            return View(contacts);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Contact contact = await _context.Contacts.FindAsync(id);
            if(contact==null) return NotFound();
            return View(contact);
        }
        public async Task<IActionResult> Delete(int id)
        {
            Contact contact = await _context.Contacts.FindAsync(id);
            if (contact == null) return NotFound();
            return View(contact);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteQuestion(int id)
        {
            Contact existedContact = await _context.Contacts.FirstOrDefaultAsync(d => d.Id == id);

            if (existedContact == null) return NotFound();

            _context.Remove(existedContact);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
