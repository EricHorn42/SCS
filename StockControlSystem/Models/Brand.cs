using System.ComponentModel.DataAnnotations;

namespace StockControlSystem.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }

        public Brand(string name)
        {
            Name = name;
        }
    }
}