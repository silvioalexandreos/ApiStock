using Microsoft.EntityFrameworkCore;
using Stock.Business.Entities;
using Stock.Business.Interfaces.Repositories;
using Stock.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Infra.Data.Repositories
{
    public class CategoryRepository : BaseRepository<CategoryProduct>, ICategoryRepository
    {
        public CategoryRepository(StockContext context) : base(context) { }

        public IEnumerable<CategoryProduct> GetAll()
        {
            return _dbSet.ToList();
        }

        public CategoryProduct GetById(Guid id)
        {
            return _dbSet.Where(x => x.Id == id).FirstOrDefault();
        }

        public CategoryProduct Insert(CategoryProduct category)
        {
            _dbSet.Add(category);
            _context.SaveChanges();

            return category;

        }

        public CategoryProduct Update(CategoryProduct category)
        {
            _dbSet.Update(category);
            _context.SaveChanges();

            return category;

        }

        public bool Delete(Guid id)
        {
            var result = _dbSet.Where(x => x.Id == id).FirstOrDefault();

            _dbSet.Update(result);
            _context.SaveChanges();

            return true;
        }
    }
}
