using Stock.Business.Entities;
using Stock.Business.Interfaces.Repositories;
using Stock.Business.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock.Services.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository RepositoryService)
        {
            _productRepository = RepositoryService;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productRepository.GetProductAll();
        }

        public async Task<Product> GetProductsById(Guid id)
        {
            return await _productRepository.GetProductById(id);
        }
    }
}
