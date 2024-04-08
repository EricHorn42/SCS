

using StockControlSystem.Models;

namespace StockControlSystem.Services.Interfaces
{
    public interface ICategoryService
    {
        Category Add(Category category);
        Category Update(Category category);
        bool Delete(Category category);
        Category GetById(int id);
        IQueryable<Category> GetAll();
    }
}
