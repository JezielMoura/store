using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Mobnet.Store.Application.Products.Events;

public class ProductDeleted : INotification
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}

public class ProductDeletedHandler : INotificationHandler<ProductDeleted>
{
    public Task Handle(ProductDeleted notification, CancellationToken token)
    {
        Console.WriteLine($"Produto {notification.Name} R$ {notification.Price} deletado");
        return Task.CompletedTask;
    }
}