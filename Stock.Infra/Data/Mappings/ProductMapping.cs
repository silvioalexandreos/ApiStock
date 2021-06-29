using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Business.Entities;

namespace Stock.Infra.Data.Mappings
{
    public class ProductMapping : BaseEntityMapping<Product>
    {
        public ProductMapping() : base(nameof(Product)) { }

        public override void Configure(EntityTypeBuilder<Product> builder)
        {
        }
    }
}
