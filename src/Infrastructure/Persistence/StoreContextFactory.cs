using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Mobnet.Store.Infrastructure.Persistence;

public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{
    public StoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();

        optionsBuilder.EnableSensitiveDataLogging(true);
        optionsBuilder.UseSqlServer("Server=mbnt.tech; Database=store; User Id=SA; Password=@Mbnt1645#$;");

        return new StoreContext(optionsBuilder.Options);
    }
}