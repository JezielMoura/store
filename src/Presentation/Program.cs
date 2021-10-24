using System.Text.Json;
using Mobnet.Store.Domain.Entities;
using Mobnet.Store.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.ConfigureExceptionHandler();

app.MapGet("/export", async (IMediator mediator) => {

    var products = await mediator.Send(new GetAllProducts());
    var orders = await mediator.Send(new GetAllOrders());
    var pgContext = new StoreContextPostgres();

    foreach (var item in products)
    {
        var c = DateTime.SpecifyKind(item.Created, DateTimeKind.Utc);
        var m = DateTime.SpecifyKind(item.LastModified, DateTimeKind.Utc);

        item.Created = c;
        item.LastModified = m;

        pgContext.Products.Add(item);
    }

    foreach (var item in orders)
    {
        var c = DateTime.SpecifyKind(item.Created, DateTimeKind.Utc);
        var m = DateTime.SpecifyKind(item.LastModified, DateTimeKind.Utc);

        item.Created = c;
        item.LastModified = m;
        
        pgContext.Add(item);
    }

    pgContext.SaveChanges();

    return Results.Ok(pgContext.Products.ToList().Count());
});


app.MapGet("/api/product", (IMediator mediator) 
    => mediator.Send(new GetAllProducts()));

app.MapGet("/api/product/{code}", (IMediator mediator, long code) 
    => mediator.Send(new GetProductById{Code = code}));

app.MapGet("/api/product/search/{term}", (IMediator mediator, string term) 
    => mediator.Send(new GetProductByName{Name = term}));

app.MapPost("/api/product", (IMediator mediator, AddProduct command) 
    => mediator.Send(command));

app.MapPut("/api/product", (IMediator mediator) 
    => mediator.Send(new GetAllProducts()));

app.MapGet("/api/product/delete", (IMediator mediator, long code) 
    => mediator.Send(new DeleteProduct(code)));

app.MapGet("/api/order", (IMediator mediator) 
    => mediator.Send(new GetAllOrders()));

app.MapGet("/api/order/{id}", (IMediator mediator, Guid id) 
    => mediator.Send(new GetOrderById(id)));

app.MapGet("/api/order/today", (IMediator mediator) 
    => mediator.Send(new GetOrderToday()));

app.MapGet("/api/order/{init}/{end}", (IMediator mediator, DateTime init, DateTime end) 
    => mediator.Send(new GetOrderByRangeDate(init, end)));

app.MapPost("/api/order", (IMediator mediator, ProcessOrder command) 
    => mediator.Send(command));

app.MapPut("/api/order", (IMediator mediator, ChangeOrder command) 
    => mediator.Send(command));

app.MapGet("/api/order/delete/{id}", (IMediator mediator, Guid id) 
    => mediator.Send(new DeleteOrder(id)));

app.Run();
