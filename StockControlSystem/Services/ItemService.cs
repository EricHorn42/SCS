using StockControlSystem.Models;
using StockControlSystem.Repositories;
using StockControlSystem.Services.Interfaces;

namespace StockControlSystem.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public bool Delete(Item item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public Item GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Item Update(Item item)
        {
            throw new NotImplementedException();
        }

        Item IItemService.Add(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
