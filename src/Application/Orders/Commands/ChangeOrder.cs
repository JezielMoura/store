using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Mobnet.Store.Application.Common.Interfaces;
using Mobnet.Store.Domain.Entities;

#nullable disable

namespace Mobnet.Store.Application.Orders.Commands;

public record ChangeOrder(Order Order) : IRequest;

public class ChangeOrderHandler : AsyncRequestHandler<ChangeOrder>
{
    private readonly IStoreContext _context;

    public ChangeOrderHandler(IStoreContext context)
    {
        _context = context;
    }

    protected override async Task Handle(ChangeOrder command, CancellationToken token)
    {
        var order = command.Order;
        var processedOrder = await _context.Orders.FindAsync(order.Id);

        foreach (var item in command.Order.Items)
        {
            var processChangeem = processedOrder.Items.FirstOrDefault(c => c.Id == item.Id);
            var product =  _context.Products.FirstOrDefault(c => c.Id == processChangeem.ProductId);

            product.InsertStock(processChangeem.Quantity);
            order.RemoveItem(item);

            _context.Products.Update(product);
            _context.Orders.Update(order);
        }

        await _context.SaveChangesAsync(token);
    }
}