using StockControlSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StockControlSystem.DTOs
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Number { get; set; }
        public string? Complement { get; set; }
        public string PostalCode { get; set; }
    }
}
