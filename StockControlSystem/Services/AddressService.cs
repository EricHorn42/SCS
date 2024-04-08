using StockControlSystem.Models;
using StockControlSystem.Services.Interfaces;

namespace StockControlSystem.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressService _addressService;

        public AddressService(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public Address Add(Address address)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Address address)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Address Update(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
