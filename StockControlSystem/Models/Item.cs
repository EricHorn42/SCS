using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StockControlSystem.Models
{
    public class Item : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public double? Weight { get; set; }
        [JsonIgnore]
        [ForeignKey("SupplierId")]
        public virtual Supplier? Supplier { get; set; }
        [JsonIgnore]
        [ForeignKey("BrandId")]
        public virtual Brand? Brand { get; set; }
        public int? BrandId { get; set; }
        [JsonIgnore]
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
        public int? CategoryId { get; set; }


    }
}
