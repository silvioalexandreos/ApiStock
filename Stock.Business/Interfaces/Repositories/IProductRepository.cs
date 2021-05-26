using Stock.Business.Entities;
using System;
using System.Collections.Generic;

namespace Stock.Business.Interfaces.Repositories
{
    public interface IProductRepository
    {
        bool Delete(Guid id);
        Product GetById(Guid id);
        IEnumerable<Product> GetAll();
        Product Insert(Product product);
        Product Update(Product product);
        IEnumerable<Product> GetByCategory(Guid categoryId);
    }
}
