using StockControlSystem.Models;
using StockControlSystem.Repositories;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class CategoryRepositoryImpl :ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepositoryImpl(Context context)
        {
            _context = context;
        }

        public void Add(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Category category = new Category
            {
                Id = id
            };
            _context.Attach(category);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public Category? FindById(int id)
        {
            return _context.Categories.Where(a => a.Id == id).FirstOrDefault();
        }

        public IQueryable<Category> GetAll()
        {
            return _context.Categories;
        }

        public void Update(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }
    }
}
