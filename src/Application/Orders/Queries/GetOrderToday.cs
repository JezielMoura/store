using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Mobnet.Store.Application.Common.Interfaces;
using Mobnet.Store.Domain.Entities;

#nullable disable

namespace Mobnet.Store.Application.Orders.Queries;

public record GetOrderToday : IRequest<IEnumerable<Order>>;

public class GetOrderTodayHandler : IRequestHandler<GetOrderToday, IEnumerable<Order>>
{
    private readonly IStoreContext _context;

    public GetOrderTodayHandler(IStoreContext context)
        => _context = context;

    public async Task<IEnumerable<Order>> Handle(GetOrderToday request, CancellationToken cancellationToken)
    {
        return await _context.Orders
            .Where(c => c.Created.Date ==  DateTime.UtcNow.Date)
            .ToListAsync();
    }
}