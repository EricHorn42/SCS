using StockControlSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace StockControlSystem.DTOs
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public double? Weight { get; set; }
    }
}
