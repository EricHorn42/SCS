using StockControlSystem.DTOs;
using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class BrandRepositoryImpl : BaseRepository<Brand, Context>
    {
        public BrandRepositoryImpl(Context context) : base(context)
        {
        }
    }
}
