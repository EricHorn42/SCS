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

        public void Add(Item item)
        {
            _itemRepository.Add(item);
        }
    }
}
