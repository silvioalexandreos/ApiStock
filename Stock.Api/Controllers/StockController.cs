using Microsoft.AspNetCore.Mvc;
using Stock.Business.Entities;
using Stock.Business.Interfaces.Services;
using System.Collections.Generic;

namespace Stock.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : Controller
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService) => _stockService = stockService;

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _stockService.GetProducts();
        }
    }
}
