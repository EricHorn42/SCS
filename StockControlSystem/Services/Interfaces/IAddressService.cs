
using StockControlSystem.Models;

namespace StockControlSystem.Services.Interfaces
{
    public interface IAddressService
    {
        Address Add(Address address);
        Address Update(Address address);
        bool Delete(Address address);
        Address GetById(int id);
        IQueryable<Address> GetAll();
    }
}
