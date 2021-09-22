using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobnet.Store.Domain.Entities;

namespace Mobnet.Store.Infrastructure.Mappings;

public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder
            .HasKey(m => m.Id);

        builder
            .Property(p => p.Id)
            .ValueGeneratedNever();

        builder
            .Property(c => c.Discount)
            .HasColumnType("decimal")
            .HasPrecision(18, 2);

        builder
            .Property(c => c.MaxDiscount)
            .HasColumnType("decimal")
            .HasPrecision(18, 2);

        builder
            .Property(c => c.Price)
            .HasColumnType("decimal")
            .HasPrecision(18, 2);

        builder
            .Property(c => c.Total)
            .HasColumnType("decimal")
            .HasPrecision(18, 2);

        builder
            .Property(c => c.Quantity)
            .HasColumnType("decimal")
            .HasPrecision(18, 2);

        builder
            .HasOne(p => p.Product)
            .WithMany()
            .HasForeignKey(c => c.ProductId);

        builder.Ignore(c => c.Product);
        builder.Ignore(c => c.Order);
    }
}