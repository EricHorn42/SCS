using StockControlSystem.Models;
using StockControlSystem.Services.Interfaces;

namespace StockControlSystem.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService _categoryService;

        public CategoryService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public Category Add(Category category)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
