using Microsoft.EntityFrameworkCore;
using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class ItemRepositoryImpl : BaseRepositoryImpl<Item, Context>
    {
        public ItemRepositoryImpl(Context context) : base(context)
        {

        }
    }
}
