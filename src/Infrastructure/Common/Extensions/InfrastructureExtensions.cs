using System.Text;
using System.Text.Json;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mobnet.Store.Application.Common.Interfaces;
using Mobnet.Store.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Mobnet.Store.Infrastructure.Extensions;

public static class InfrastructureExtensions
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
            services.AddDbContext<StoreContext>(options =>  
                options.UseSqlServer("Server=mbnt.tech; Database=store; User Id=sa; Password=@Mbnt1645#$;", 
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