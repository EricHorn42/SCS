using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class BrandRepositoryImpl : BaseRepositoryImpl<Brand, Context>
    {
        public BrandRepositoryImpl(Context context) : base(context)
        {
        }
    }
}
