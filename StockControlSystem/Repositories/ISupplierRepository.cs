
using StockControlSystem.Models;

namespace StockControlSystem.Repositories
{
    public interface ISupplierRepository
    {
        void Add(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(int id);
        IQueryable<Supplier> GetAll();
        Supplier? FindById(int id);
    }
}
