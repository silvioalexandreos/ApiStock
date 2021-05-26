using Stock.Business.Entities;
using Stock.Business.Interfaces.Repositories;
using Stock.Infra.Data.Context;
using System;
using System.Collections.Generic;

namespace Stock.Infra
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(StockContext context)
            : base(context) { }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetByCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Product GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Product Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
