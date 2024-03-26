using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StockControlSystem.Models
{
    public class Address : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Street { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? State { get; set; }
        [Required]
        public string? Country { get; set; }
        [Required]
        public int Number { get; set; }
        public string? Complement { get; set; }
        [Required]
        public string? PostalCode { get; set; }
        [JsonIgnore]
        [ForeignKey("SupplierId")]
        public virtual Supplier? Supplier { get; set; }

    }
}