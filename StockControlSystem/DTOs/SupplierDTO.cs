using StockControlSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StockControlSystem.DTOs
{
    public class SupplierDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string CNPJ { get; set; }
        
    }
}
