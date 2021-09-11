namespace Mobnet.Store.Application.Orders.Commands;

using Ardalis.GuardClauses;
using MediatR;
using Mobnet.Store.Application.Common.Interfaces;
using Mobnet.Store.Domain.Entities;

public record ProcessOrder(IEnumerable<OrderItem> Items) : IRequest;

public class ProcessOrderHandler : AsyncRequestHandler<ProcessOrder>
{
    private readonly IStoreContext _context;

    public ProcessOrderHandler(IStoreContext context)
        => _context = context;

    protected override async Task Handle(ProcessOrder command, CancellationToken token)
    {
        var order = new Order();

        foreach (var item in command.Items)
        {
            var product = _context.Products.Find(item.ProductId);

            Guard.Against.Null(product, nameof(product));

            product.RetireStock(item.Quantity);
            order.AddItem(item);

            _context.Products.Update(product);
        }

        _context.Orders.Add(order);

        await _context.SaveChangesAsync(token);
    }
}