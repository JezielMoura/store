global using Mobnet.Store.Infrastructure.Extensions;
global using Serilog.Formatting.Compact;
global using Mobnet.Store.Application.Common.Extensions;
global using Serilog;
global using MediatR;
global using Microsoft.AspNetCore.Mvc;
global using Mobnet.Store.Application.Products.Commands;
global using Mobnet.Store.Application.Products.Queries;
global using Mobnet.Store.Domain.Entities;
global using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File(new CompactJsonFormatter(), "logs/store.json", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Services.AddApplication();
builder.Services.AddInfrastructure();
builder.Services.AddControllers().AddJsonOptions(options 
    => options.JsonSerializerOptions.ReferenceHandler  = ReferenceHandler.IgnoreCycles);

builder.Services.AddCors();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c 
    => c.SwaggerDoc("v1", new() { Title = "Mobnet Store", Version = "v1" }));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mobnet Store"));
}

app.ConfigureExceptionHandler();
app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed(o => true));
app.UseRouting();
app.UseEndpoints(route => route.MapControllers());

app.Run();
