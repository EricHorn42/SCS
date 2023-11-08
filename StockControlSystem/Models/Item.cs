using System.ComponentModel.DataAnnotations;

namespace StockControlSystem.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Supplier Supplier { get; set; }
        [Required]
        public Category Category { get; set; }
        public string? Description { get; set; }
        public double? Weight { get; set; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
