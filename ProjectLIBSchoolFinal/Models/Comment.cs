using System;
using System.ComponentModel.DataAnnotations;

namespace LIBSchool_FinalProjectBackEnd.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Subject { get; set; }
        public AppUser AppUser { get; set; }
        public bool Status { get; set; }
    }
}
