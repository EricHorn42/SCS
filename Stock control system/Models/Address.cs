using System.ComponentModel.DataAnnotations;

namespace Stock_control_system.Models
{
    public class Address
    {
        [Required]
        private string Street { get; set; }
        [Required]
        private string City { get; set; }
        [Required]
        private string State { get; set; }
        [Required]
        private string Country { get; set; }
        private string? PostalCode { get; set; }
        
        
    }
}