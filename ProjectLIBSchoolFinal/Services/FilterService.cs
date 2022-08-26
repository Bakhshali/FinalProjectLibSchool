using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
using System.Collections.Generic;
using System.Linq;

namespace LIBSchool_FinalProjectBackEnd.Services
{
    public class FilterService
    {
        private readonly AppDbContext _context;

        public FilterService(AppDbContext context)
        {
            _context = context;
        }
        public List<Course> GetCourse(int? filter,int? minprice,int? maxprice)
        {
            IQueryable<Course> courses = _context.Courses.AsQueryable();

            switch (filter)
            {
                case 1:
                    courses = courses.OrderBy(c => c.Price);
                    break;
                case 2:
                    courses = courses.OrderByDescending(c => c.Price);
                    break;
                default:
                    break;
            }
            return courses.ToList();
        }
    }


}
