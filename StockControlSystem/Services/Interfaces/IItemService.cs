using StockControlSystem.Models;
using StockControlSystem.Repositories;
using System.Collections;

namespace StockControlSystem.Services.Interfaces
{
    public interface IItemService
    {
        Item Add(Item item);
        Item Update(Item item);
        bool Delete(Item item);
        Item GetById(int id);
        IQueryable<Item> GetAll();

    }
}
