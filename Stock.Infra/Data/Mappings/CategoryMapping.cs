using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Business.Entities;

namespace Stock.Infra.Data.Mappings
{
    public class CategoryMapping : BaseEntityMapping<CategoryProduct>
    {
        public CategoryMapping() : base(nameof(CategoryProduct)) { }

        public override void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            base.Configure(builder);
        }
    }
}
