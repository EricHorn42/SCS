using StockControlSystem.Models;
using System.Collections;

namespace StockControlSystem.Repositories
{
    public interface IItemRepository
    {
        void Add(Item item);
        void Update(Item item);
        void Delete(int id);
        IQueryable<Item> GetAll();
        Item? FindById(int id);
    }
}
