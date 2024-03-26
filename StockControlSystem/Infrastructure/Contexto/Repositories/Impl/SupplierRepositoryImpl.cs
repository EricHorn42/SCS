using Microsoft.EntityFrameworkCore;
using StockControlSystem.Models;
using StockControlSystem.Repositories;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class SupplierRepositoryImpl : ISupplierRepository
    {

        private readonly Context _context;

        public SupplierRepositoryImpl(Context context)
        {
            _context = context;
        }

        public void Add(Supplier supplier)
        {
            _context.Add(supplier);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Supplier supplier = new Supplier
            {
                Id = id
            };
            _context.Attach(supplier);
            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();
        }

        public Supplier? FindById(int id)
        {
            return _context.Suppliers.Where(a => a.Id == id).FirstOrDefault();
        }

        public IQueryable<Supplier> GetAll()
        {
            return _context.Suppliers;
        }

        public void Update(Supplier supplier)
        {
            _context.Update(supplier);
            _context.SaveChanges();
        }
    }
}
