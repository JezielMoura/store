using MediatR;
using Microsoft.EntityFrameworkCore;
using Mobnet.Store.Application.Common.Interfaces;
using Mobnet.Store.Domain.Entities;

#nullable disable

namespace Mobnet.Store.Application.Orders.Queries;

public record GetOrderById (Guid id) : IRequest<Order>;

public class GetOrderByIdHandler : IRequestHandler<GetOrderById, Order>
{
    private readonly IStoreContext _context;

    public GetOrderByIdHandler(IStoreContext context)
        => _context = context;

    public async Task<Order> Handle(GetOrderById request, CancellationToken cancellationToken)
    {
        return await _context.Orders
            .Include(c => c.Items)
            .ThenInclude(c => c.Product)
            .FirstOrDefaultAsync(c => c.Id ==  request.id);
    }
}