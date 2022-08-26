using LIBSchool_FinalProjectBackEnd.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LIBSchool_FinalProjectBackEnd.ViewModels
{
    public class OrderVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Telefon nömrəsi düzgün deyil(nömrə 0 ilə başlamalıdır).")]
        public string Phone { get; set; }

        [Required]
        public string Location { get; set; }
        public string Subject { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
