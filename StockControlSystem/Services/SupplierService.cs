using StockControlSystem.Models;
using StockControlSystem.Services.Interfaces;

namespace StockControlSystem.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierService _supplierService;

        public SupplierService(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        public Supplier Add(Supplier supplier)
        {
            
        }

        public bool Delete(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Supplier> GetAll()
        {
            throw new NotImplementedException();
        }

        public Supplier GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Supplier Update(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
