using Stock.Business.Entities;
using Stock.Business.Interfaces.Repositories;
using Stock.Business.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stock.Services.Business
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository RepositoryService)
        {
            _categoryRepository = RepositoryService;
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductsById(Guid id)
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<Product>> GetProducts()
        //{
        //    return await _categoryRepository.GetAll();
        //}

        //public async Task<Product> GetProductsById(Guid id)
        //{
        //    return await _categoryRepository.GetProductById(id);
        //}
    }
}
