using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class SupplierRepositoryImpl : BaseRepository<Supplier, Context>
    {
        public SupplierRepositoryImpl(Context context) : base(context)
        {
        }
    }
}
