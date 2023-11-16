using Microsoft.AspNetCore.Mvc;
using StockControlSystem.DTOs;
using StockControlSystem.Infrastructure.Contexto.Repositories.Impl;
using StockControlSystem.Models;

namespace StockControlSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : BaseController<Brand, BrandRepositoryImpl>
    {
        public BrandController(BrandRepositoryImpl repository) : base(repository)
        {
        }
    }
}
