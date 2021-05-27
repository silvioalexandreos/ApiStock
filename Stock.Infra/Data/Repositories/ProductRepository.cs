using Microsoft.EntityFrameworkCore;
using Stock.Business.Entities;
using Stock.Business.Interfaces.Repositories;
using Stock.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock.Infra
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(StockContext context)
            : base(context) { }

        public async Task<IEnumerable<Product>> GetProductAll()
        {
            return await _dbSet.ToListAsync();
        }

        public Task<Product> GetProductById(Guid id)
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

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IProductRepository.GetByCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
