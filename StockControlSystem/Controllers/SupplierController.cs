using Microsoft.AspNetCore.Mvc;
using StockControlSystem.Infrastructure.Contexto.Repositories.Impl;
using StockControlSystem.Models;

namespace StockControlSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : BaseController<Supplier, SupplierRepositoryImpl>
    {
        public SupplierController(SupplierRepositoryImpl repository) : base(repository)
        {
        }
    }
}
