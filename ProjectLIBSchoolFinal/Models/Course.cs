using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIBSchool_FinalProjectBackEnd.Models
{
    public class Course
    {
        public int Id { get; set; }

        
        public string Image { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }

        public string SubName { get; set; }
        
        public string İnformation { get; set; }
        
        public string BelongTitle { get; set; }

        public string BelongText { get; set; }

        public string Condition { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int DiscountId { get; set; }
        public Discount Discount { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
