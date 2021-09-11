using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobnet.Store.Domain.Entities;

namespace Mobnet.Store.Infrastructure.Mappings;

public class OrderMap : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(p => p.Id).ValueGeneratedNever();

        builder.HasMany(p => p.Items).WithOne(p => p.Order).HasForeignKey(fk => fk.OrderId);
    }
}