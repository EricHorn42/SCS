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
    }
}
