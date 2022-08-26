using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Services;
using LIBSchool_FinalProjectBackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LIBSchool_FinalProjectBackEnd.Controllers
{
    public class StartCourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly FilterService _filterService;

        public StartCourseController(AppDbContext context)
        {
            _context = context;
            _filterService = new FilterService(context);
        }

        public IActionResult Index(int? filter,int? minprice,int? maxprice)
        {
            FilterCourseVM model = new FilterCourseVM
            {
                Courses = _filterService.GetCourse(filter,minprice,maxprice),
                Filter = filter,
                MaxPrice = maxprice,
                MinPrice = minprice,
            };
            return View(model);
        }
    }
}
