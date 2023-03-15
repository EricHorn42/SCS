using System.ComponentModel.DataAnnotations;

namespace Stock_control_system.Models
{
    public class StockBalance
    {
        [Key]
        private int Id { get; set; }
        [Required]
        private Item Item { get; set; }
        [Required]
        private int Quantity { get; set; } = 0;
    }
}
