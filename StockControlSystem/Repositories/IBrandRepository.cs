
using StockControlSystem.Models;

namespace StockControlSystem.Repositories
{
    public interface IBrandRepository
    {
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(int id);
        IQueryable<Brand> GetAll();
        Brand FindById(int id);
    }
}
