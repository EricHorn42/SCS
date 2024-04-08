using FluentValidation;
using StockControlSystem.Infrastructure;
using StockControlSystem.Models;
using StockControlSystem.Repositories;
using StockControlSystem.Services.Interfaces;
using FluentValidation;
using StockControlSystem.Validators;

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
            Validate(brand);
            _brandRepository.Add(brand);
            return brand;
        }

        public bool Delete(Brand brand)
        {
            try
            {
                _brandRepository.Delete(brand.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable<Brand> GetAll()
        {
            return _brandRepository.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandRepository.FindById(id);
        }

        public void Update(Brand brand)
        {
            _brandRepository.Update(brand);
        }

        private void Validate(Brand obj)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            Activator.CreateInstance<BrandValidator>().ValidateAndThrow(obj);
        }
    }
}
