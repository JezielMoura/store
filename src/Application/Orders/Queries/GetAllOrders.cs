namespace Mobnet.Store.Application.Orders.Queries;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Mobnet.Store.Application.Common.Interfaces;
using Mobnet.Store.Domain.Entities;

public record GetAllOrders : IRequest<IEnumerable<Order>>;

public class GetAllOrdersHandler : IRequestHandler<GetAllOrders, IEnumerable<Order>>
{
    private readonly IStoreContext _context;

    public GetAllOrdersHandler(IStoreContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Order>> Handle(GetAllOrders request, CancellationToken cancellationToken)
    {
        return await _context.Orders.Include(c => c.Items).ToListAsync();
    }
}