using Microsoft.AspNetCore.Mvc;
using StockControlSystem.Infrastructure.Contexto.Repositories.Impl;
using StockControlSystem.Models;

namespace StockControlSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController<Category, CategoryRepositoryImpl>
    {
        public CategoryController(CategoryRepositoryImpl repository) : base(repository)
        {
        }
    }
}
