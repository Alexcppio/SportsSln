using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace SportsStore.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        // Пожалуйста, введите наименование товара
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a description")]
        // Пожалуйста, введите описание
        public string Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        // Пожалуйста, введите положительную цену
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please specify a category")]
        // Пожалуйста, укажите категорию
        public string Category { get; set; }
    }
}
