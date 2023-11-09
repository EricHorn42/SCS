using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StockControlSystem.Models
{
    public class Address : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public int Number { get; set; }
        public string? Complement { get; set; }
        [Required]
        public string PostalCode { get; set; }
        public int? SupplierID { get; set; }
        [JsonIgnore]
        public virtual Supplier? Supplier { get; set; }

        public Address(string street, string city, string state, string country, string postalCode, int number)
        { 
            Street = street;
            City = city;
            State = state;
            Country = country;
            PostalCode = postalCode;
            Number = number;
        }
    }
}