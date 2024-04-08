using Microsoft.AspNetCore.Mvc;
using StockControlSystem.DTOs;
using StockControlSystem.Infrastructure.Contexto.Repositories.Impl;
using StockControlSystem.Models;
using StockControlSystem.Services;
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
        public ActionResult GetAll()
        {
            try
            {
                return Ok(_brandService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                Brand brand = _brandService.GetById(id);

                if (brand == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(brand);
                }
            }
            catch (Exception ex) { return BadRequest(ex); }
        }
    }
}
