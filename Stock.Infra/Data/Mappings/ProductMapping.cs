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
            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.UnitPrice)
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Property(x => x.Amount)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);

            base.Configure(builder);
        }
    }
}
