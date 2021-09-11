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
            .HasOne(p => p.Product)
            .WithMany()
            .HasForeignKey(c => c.ProductId);
    }
}