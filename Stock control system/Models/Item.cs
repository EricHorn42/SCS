using System.ComponentModel.DataAnnotations;

namespace Stock_control_system.Models
{
    public class Item
    {
        [Key]
        [Required]
        private int Id { get; set; }
        [Required]
        private string Name { get; set; }
        [Required]
        private int? Price { get; set; } = 0;
        [Required]
        private Supplier? supplier { get; set; }
        [Required]
        private Brand? Brand { get; set; }
        [Required]
        private Category? Category { get; set; }
        private string? Description { get; set; }
        private double? Weight { get; set; }
    }
}
