using Microsoft.EntityFrameworkCore;
using Stock.Business.Entities;

namespace Stock.Infra.Data.Context
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions<StockContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryProduct> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StockContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
