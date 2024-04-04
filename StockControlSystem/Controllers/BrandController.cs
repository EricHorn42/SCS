using Microsoft.AspNetCore.Mvc;
using StockControlSystem.DTOs;
using StockControlSystem.Infrastructure.Contexto.Repositories.Impl;
using StockControlSystem.Models;
using StockControlSystem.Services.Interfaces;

namespace StockControlSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public ActionResult Add([FromBody] Brand brand)
        {
            try
            {
                _brandService.Add(brand);
                return Ok(brand);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet]
        public ActionResult ListAll()
        {
            return Ok(_brandService.GetAll());
        }
    }
}
