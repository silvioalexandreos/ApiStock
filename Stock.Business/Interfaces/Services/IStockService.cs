using Stock.Business.Entities;
using System.Collections.Generic;

namespace Stock.Business.Interfaces.Services
{
    public interface IStockService
    {
        IEnumerable<Product> GetProducts();
    }
}
