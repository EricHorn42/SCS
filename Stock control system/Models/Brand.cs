using System.ComponentModel.DataAnnotations;

namespace Stock_control_system.Models
{
    public class Brand
    {
        [Required]
        private int Id { get; set; }
        [Required]
        private string Name { get; set; }
        private string? Description { get; set; }
        
    }

    
}