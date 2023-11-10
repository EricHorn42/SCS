using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class AddressRepositoryImpl : BaseRepositoryImpl<Address, Context>
    {
        public AddressRepositoryImpl(Context context) : base(context)
        {
        }
    }
}
