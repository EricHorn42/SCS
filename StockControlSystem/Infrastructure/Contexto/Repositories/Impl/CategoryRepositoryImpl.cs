using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class CategoryRepositoryImpl : BaseRepositoryImpl<Category, Context>
    {
        public CategoryRepositoryImpl(Context context) : base(context)
        {
        }
    }
}
