using Microsoft.AspNetCore.Mvc;
using Stock.Business.Entities;
using Stock.Business.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _stockService;

        public ProductController(IProductService stockService) => _stockService = stockService;

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _stockService.GetProducts();
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<Product>> GetProductId()
        {
            return await _stockService.GetProducts();
        }
    }
}
