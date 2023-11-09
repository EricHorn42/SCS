using System.ComponentModel.DataAnnotations;

namespace StockControlSystem.Models
{
    public class Item : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public double? Weight { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public int? SupplierId { get; set; }
        public virtual Brand? Brand { get; set; }
        public int? BrandId { get; set; }
        public virtual Category? Category { get; set; }
        public int? CategoryId { get; set; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
