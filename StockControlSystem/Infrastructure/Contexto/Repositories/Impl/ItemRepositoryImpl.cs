using Microsoft.EntityFrameworkCore;
using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class ItemRepositoryImpl : BaseRepository<Item, Context>
    {
        public ItemRepositoryImpl(Context context) : base(context)
        {

        }
    }
}
