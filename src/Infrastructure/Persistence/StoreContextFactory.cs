using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Mobnet.Store.Infrastructure.Persistence;

public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{
    public StoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();

        optionsBuilder.EnableSensitiveDataLogging(true);
        optionsBuilder.UseNpgsql("Server=127.0.0.1; Database=store; User Id=postgres; Password=mbnt1645;");

        return new StoreContext(optionsBuilder.Options);
    }
}