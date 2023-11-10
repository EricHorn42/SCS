using Microsoft.AspNetCore.Mvc;
using StockControlSystem.Infrastructure.Contexto.Repositories.Impl;
using StockControlSystem.Models;

namespace StockControlSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : BaseController<Address, AddressRepositoryImpl>
    {
        public AddressController(AddressRepositoryImpl repository) : base(repository)
        {
        }
    }
}
