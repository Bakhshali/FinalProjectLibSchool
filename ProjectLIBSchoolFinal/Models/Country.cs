using System.Collections.Generic;

namespace LIBSchool_FinalProjectBackEnd.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Graduate> Graduates { get; set; }
    }
}
