using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mobnet.Store.Application.Common.Interfaces;
using Mobnet.Store.Domain.Entities;
using Mobnet.Store.Domain.Shared;

#nullable disable

namespace Mobnet.Store.Infrastructure.Persistence;

public class StoreContextPostgres : DbContext
{
    public StoreContextPostgres()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("server=localhost;database=store;User Id=postgres;password=mbnt1645");
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        builder.Entity<Product>().HasData(StoreContextSeed.SeedProducts());

        base.OnModelCreating(builder);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<Entity>())
        {
            if (entry.State == EntityState.Added)
                entry.Entity.Created = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);

            if (entry.State == EntityState.Modified)
                entry.Entity.LastModified = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}