using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Business.Entities;

namespace Stock.Infra.Data.Mappings
{
    public class BaseEntityMapping<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity
    {
        private readonly string _tableName;

        public BaseEntityMapping(string tableName) => _tableName = tableName;

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Active)
                .HasColumnType("boolean")
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .HasColumnType("timestamp ")
                .IsRequired();

            builder.Property(x => x.UpdatedAt)
                .HasColumnType("timestamp");

            builder.ToTable(_tableName);
        }
    }
}
