using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StockControlSystem.Models
{
    public class Supplier : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CNPJ { get; set; }
        public string? Description { get; set; }
        [JsonIgnore]
        public virtual ICollection<Address>? Addresses { get; set; }
        [JsonIgnore]
        public virtual ICollection<Item>? Itens { get; set; }

   
    }
}
