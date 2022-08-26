using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LIBSchool_FinalProjectBackEnd.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
