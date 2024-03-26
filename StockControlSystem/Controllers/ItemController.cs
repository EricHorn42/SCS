using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StockControlSystem.Infrastructure.Contexto.Repositories;
using StockControlSystem.Infrastructure.Contexto.Repositories.Impl;
using StockControlSystem.Models;
using StockControlSystem.Services;
using StockControlSystem.Services.Interfaces;

namespace StockControlSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost]
        public ActionResult Add([FromBody] Item item) {
            _itemService.Add(item);
            return Ok(item);
        }

    }
}
