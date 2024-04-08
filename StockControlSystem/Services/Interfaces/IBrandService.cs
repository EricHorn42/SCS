
using StockControlSystem.DTOs;
using StockControlSystem.Models;

namespace StockControlSystem.Services.Interfaces
{
    public interface IBrandService
    {
        Brand Add(Brand brand);
        Brand Update(Brand brand);
        void Delete(Brand brand);
        Brand GetById(int id);
        IQueryable<Brand> GetAll(); 
    }
}
