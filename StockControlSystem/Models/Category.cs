using System.ComponentModel.DataAnnotations;

namespace StockControlSystem.Models
{
    public class Category : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Item> Itens { get; set; }    

        public Category(string Name) 
        {
            Name = Name;
        }
    }
}