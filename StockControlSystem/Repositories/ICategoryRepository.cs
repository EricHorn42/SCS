

using StockControlSystem.Models;

namespace StockControlSystem.Repositories
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
        IQueryable<Category> GetAll();
        Category? FindById(int id);
    }
}
