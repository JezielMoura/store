namespace Mobnet.Store.Application.Orders.Commands;

using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Mobnet.Store.Application.Common.Interfaces;

#nullable disable

public record DeleteOrder(Guid Id) : IRequest;

public class DeleteOrderHandler : AsyncRequestHandler<DeleteOrder>
{
    private readonly IStoreContext _context;

    public DeleteOrderHandler(IStoreContext context)
        => _context = context;

    protected override async Task Handle(DeleteOrder command, CancellationToken token)
    {
        var order = await _context.Orders.FindAsync(command.Id);

        _context.Orders.Update(order);
        await _context.SaveChangesAsync(token);
    }
}