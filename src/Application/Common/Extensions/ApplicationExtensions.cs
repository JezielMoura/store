using System.Reflection;
using FluentValidation;
using MediatR;
using Mobnet.Store.Application.Behaviours;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http.Json;
using System.Text.Json.Serialization;

namespace Mobnet.Store.Application.Common.Extensions;

public static class ApplicationExtensions   
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

        services.Configure<JsonOptions>(options 
            => options.SerializerOptions.ReferenceHandler  = ReferenceHandler.IgnoreCycles);
    }
}