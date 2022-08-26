using LIBSchool_FinalProjectBackEnd.Models;
using System.Collections.Generic;

namespace LIBSchool_FinalProjectBackEnd.ViewModels
{
    public class FilterCourseVM
    {
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public int? Filter { get; set; }
        public List<Course> Courses { get; set; }
    }
}
