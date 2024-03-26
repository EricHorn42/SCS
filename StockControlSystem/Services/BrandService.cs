using StockControlSystem.Infrastructure;
using StockControlSystem.Models;
using StockControlSystem.Repositories;
using StockControlSystem.Services.Interfaces;

namespace StockControlSystem.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public Brand Add(Brand brand)
        {
            _brandRepository.Add(brand);
            return brand;
        }
    }
}
