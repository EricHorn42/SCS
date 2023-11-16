using StockControlSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace StockControlSystem.DTOs
{
    public class BrandDTO:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
