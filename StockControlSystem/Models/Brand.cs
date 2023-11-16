using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StockControlSystem.Models
{
    public class Brand : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [JsonIgnore]
        public virtual ICollection<Item>? Itens { get; set; }


    }
}