namespace Mobnet.Store.Infrastructure.Extensions;

public static class InfrastructureExtensions
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
            services.AddDbContext<StoreContext>(options =>  
                options.UseNpgsql("server=postgres;database=store;User Id=postgres;password=mbnt1645", 
                    builder => builder.MigrationsAssembly("Mobnet.Store.Infrastructure"))
            );

        services.AddTransient<IStoreContext, StoreContext>();
    }

    public static void ConfigureExceptionHandler(this IApplicationBuilder app)
    {
        app.Use(async (ctx, next) =>
        {
            try
            {
                await next();
            }
            catch (ValidationException e)
            {
                var response = ctx.Response;

                response.Clear();
                response.StatusCode = StatusCodes.Status400BadRequest;
                response.ContentType = "application/json";

                await response.WriteAsync(JsonSerializer.Serialize(new
                {
                    Message = "Erro na validação dos dados",
                    Errors = e.Errors.ToDictionary(e => e.PropertyName, e => e.ErrorMessage)
                }), Encoding.UTF8, ctx.RequestAborted);
            }
        });
    }
}
