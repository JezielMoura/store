using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Serilog;

namespace Mobnet.Store.Application.Products.Events;

public class ProductUpdated : INotification
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}

public class ProductUpdatedHandler : INotificationHandler<ProductUpdated>
{
    public Task Handle(ProductUpdated notification, CancellationToken token)
    {
        Log.Information($"Produto {notification.Name} R$ {notification.Price} alterado");
        return Task.CompletedTask;
    }
}