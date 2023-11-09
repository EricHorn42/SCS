using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockControlSystem.Infrastructure.Contexto.Repositories;
using StockControlSystem.Infrastructure.Contexto.Repositories.Impl;
using StockControlSystem.Models;

namespace StockControlSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : BaseController<Item, ItemRepositoryImpl>
    {
        
        public ItemController(ItemRepositoryImpl itemRepository): base(itemRepository)
        {

        }

    }
}
