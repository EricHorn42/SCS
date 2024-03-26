using StockControlSystem.Models;
using StockControlSystem.Repositories;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class AddressRepositoryImpl : IAddressRepository
    {
        private readonly Context _context;

        public AddressRepositoryImpl(Context context)
        {
            _context = context;
        }

        public void Add(Address address)
        {
            _context.Add(address);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Address address = new Address
            {
                Id = id
            };
            _context.Attach(address);
            _context.Addresses.Remove(address);
            _context.SaveChanges();
        }

        public Address? FindById(int id)
        {
            return _context.Addresses.Where(a => a.Id == id).FirstOrDefault();
        }

        public IQueryable<Address> GetAll()
        {
            return _context.Addresses;
        }

        public void Update(Address address)
        {
            _context.Update(address);
        }
    }
}
