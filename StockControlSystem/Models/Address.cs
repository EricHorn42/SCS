using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace StockControlSystem.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string PostalCode { get; set; }

        public Address(string street, string city, string state, string country, string postalCode)
        { 
            Street = street;
            City = city;
            State = state;
            Country = country;
            PostalCode = postalCode;
        }
    }
}