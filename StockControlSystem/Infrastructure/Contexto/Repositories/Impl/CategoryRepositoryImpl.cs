using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class CategoryRepositoryImpl : BaseRepository<Category, Context>
    {
        public CategoryRepositoryImpl(Context context) : base(context)
        {
        }
    }
}
