using StockControlSystem.DTOs;
using StockControlSystem.Models;
using StockControlSystem.Repositories;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class BrandRepositoryImpl : IBrandRepository
    {
        private readonly Context _context;

        public BrandRepositoryImpl(Context context)
        {
            _context = context;
        }

        public Brand Add(Brand brand)
        {
            _context.Add(brand);
            _context.SaveChanges();
            return brand;
        }

        public void Delete(int id)
        {
            Brand brand = new Brand
            {
                Id = id
            };
            _context.Attach(brand);
             _context.Brands.Remove(brand);
            _context.SaveChanges();
        }

        public Brand? FindById(int id)
        {
            return _context.Brands.Where(a => a.Id == id).FirstOrDefault();
        }

        public IQueryable<Brand> GetAll()
        {
            return _context.Brands;
        }

        public Brand Update(Brand brand)
        {
            return _context.Update(brand).Entity;
        }
    }
}
