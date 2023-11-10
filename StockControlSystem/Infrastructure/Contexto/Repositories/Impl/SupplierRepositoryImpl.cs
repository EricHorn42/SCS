using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class SupplierRepositoryImpl : BaseRepositoryImpl<Supplier, Context>
    {
        public SupplierRepositoryImpl(Context context) : base(context)
        {
        }
    }
}
