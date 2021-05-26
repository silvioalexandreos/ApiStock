using Stock.Business.Entities;
using System;
using System.Collections.Generic;

namespace Stock.Business.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        bool Delete(Guid id);
        CategoryProduct GetById(Guid id);
        IEnumerable<CategoryProduct> GetAll();
        CategoryProduct Insert(CategoryProduct category);
        CategoryProduct Update(CategoryProduct category);
    }
}
