using System.Collections.Generic;

namespace LIBSchool_FinalProjectBackEnd.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public int Percent { get; set; }
        public List<Course> Courses { get; set; }
    }
}
