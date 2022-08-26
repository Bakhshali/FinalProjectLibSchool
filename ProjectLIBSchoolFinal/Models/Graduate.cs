using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIBSchool_FinalProjectBackEnd.Models
{
    public class Graduate
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Work { get; set; }
        [Required]
        public string Master { get; set; }
        [Required]
        public string University { get; set; }
        public bool IsChoose { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
