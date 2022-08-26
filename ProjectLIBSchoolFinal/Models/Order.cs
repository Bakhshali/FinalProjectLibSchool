using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LIBSchool_FinalProjectBackEnd.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }
        [Required]
        public string Location { get; set; }
        [Required, DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Telefon nömrəsi düzgün deyil(nömrə 0 ilə başlamalıdır).")]
        public string Phone { get; set; }

        public string Subject { get; set; }
        public decimal? TotalPrice { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}
