using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Serilog;

namespace Mobnet.Store.Application.Products.Events;

public class ProductCreated : INotification
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}

public class ProductCreatedHandler : INotificationHandler<ProductCreated>
{

    public Task Handle(ProductCreated notification, CancellationToken token)
    {
        Log.Information($"Produto {notification.Name} R$ {notification.Price} cadastrado");
        
        return Task.CompletedTask;
    }
}