using Stock.Business.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock.Business.Interfaces.Repositories
{
    public interface IProductRepository
    {
        bool Delete(Guid id);
        Task<Product> GetProductById(Guid id);
        Task<IEnumerable<Product>> GetProductAll();
        Product Insert(Product product);
        Product Update(Product product);
        Task<IEnumerable<Product>> GetByCategory(Guid categoryId);
    }
}
