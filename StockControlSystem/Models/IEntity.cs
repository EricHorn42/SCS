using System.ComponentModel.DataAnnotations;

namespace StockControlSystem.Models
{
    public interface IEntity
    {
        [Key]
        int Id { get; set; }
    }
}
