using Stock.Business.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock.Business.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Product>> GetProducts();

        Task<Product> GetProductsById(Guid id);
    }
}
