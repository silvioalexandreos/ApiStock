using Stock.Business.Entities;
using Stock.Business.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryProduct GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public CategoryProduct Insert(CategoryProduct category)
        {
            throw new NotImplementedException();
        }

        public CategoryProduct Update(CategoryProduct category)
        {
            throw new NotImplementedException();
        }
    }
}
