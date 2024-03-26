
using StockControlSystem.Models;

namespace StockControlSystem.Repositories
{
    public interface IAddressRepository
    {
        void Add(Address address);
        void Update(Address address);
        void Delete(int id);
        IQueryable<Address> GetAll();
        Address? FindById(int id);
    }
}
