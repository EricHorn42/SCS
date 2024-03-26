using Microsoft.EntityFrameworkCore;
using StockControlSystem.Models;
using StockControlSystem.Repositories;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class ItemRepositoryImpl : IItemRepository
    {
        private readonly Context _context;

        public ItemRepositoryImpl(Context context)
        {
            _context = context;
        }

        public void Add(Item item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Item item = new Item
            {
                Id = id
            };
            _context.Attach(item);
            _context.Itens.Remove(item);
            _context.SaveChanges();
        }

        public Item? FindById(int id)
        {
            return _context.Itens.Where(a => a.Id == id).FirstOrDefault();
        }

        public IQueryable<Item> GetAll()
        {
            return _context.Itens;
        }

        public void Update(Item item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
