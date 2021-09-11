using Microsoft.EntityFrameworkCore;
using Mobnet.Store.Domain.Entities;

namespace Mobnet.Store.Application.Common.Interfaces;

public interface IStoreContext
{
    DbSet<Product> Products { get; set; }
    DbSet<Order> Orders { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}