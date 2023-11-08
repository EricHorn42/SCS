using System.ComponentModel.DataAnnotations;

namespace StockControlSystem.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Item> Items { get; set; }    

        public Category(string Name) 
        {
            Name = Name;
        }
    }
}