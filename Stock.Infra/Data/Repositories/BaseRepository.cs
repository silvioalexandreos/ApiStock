using Microsoft.EntityFrameworkCore;
using Stock.Business.Entities;
using System;

namespace Stock.Infra
{
    public abstract class BaseRepository<TEntity> : IDisposable where TEntity : Entity
    {
        internal readonly DbContext _context;
        internal readonly DbSet<TEntity> _dbSet;

        protected BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
