
using StockControlSystem.Models;

namespace StockControlSystem.Services.Interfaces
{
    public interface ISupplierService
    {
        Supplier Add(Supplier supplier);
        Supplier Update(Supplier supplier);
        bool Delete(Supplier supplier);
        Supplier GetById(int id);
        IQueryable<Supplier> GetAll();
    }
}
