using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("Brands").HasKey(b=>b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
        builder.Property(b=>b.CreateDate).HasColumnName("CreateDate").IsRequired();
        builder.Property(b => b.UpdateDate).HasColumnName("UpdateDate");
        builder.Property(b => b.DeleteDate).HasColumnName("DeleteDate");

        builder.HasQueryFilter(b=>!b.DeleteDate.HasValue);
    }
}
