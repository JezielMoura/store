using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobnet.Store.Domain.Entities;

namespace Mobnet.Store.Infrastructure.Mappings;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(p => p.Id).ValueGeneratedNever();
        builder.Property(p => p.Name).IsRequired().HasMaxLength(90);
        builder.Property(p => p.Description).HasMaxLength(120);
        builder.Property(p => p.Price).HasPrecision(10, 2);
        builder.Property(p => p.PurchasePrice).HasPrecision(10, 2);
        builder.Property(p => p.MaxDiscount).HasPrecision(10, 2);

        builder
            .Property(c => c.Price)
            .HasColumnType("decimal")
            .HasPrecision(18, 2);

        builder
            .Property(c => c.Stock)
            .HasColumnType("decimal")
            .HasPrecision(18, 2);

        builder
            .Property(c => c.StockMin)
            .HasColumnType("decimal")
            .HasPrecision(18, 2);
    }
}