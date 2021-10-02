using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        // Пожалуйста, введите имя
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the first address line")]
        // Пожалуйста, введите первую строку адреса
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Please enter a city name")]
        // Пожалуйста, введите название города
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state name")]
        // Пожалуйста, введите название штата
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a country name")]
        // Пожалуйста, введите название страны
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
