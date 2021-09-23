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

public record GetOrderByRangeDate (DateTime Init, DateTime End) : IRequest<IEnumerable<Order>>;

public class GetOrderByRangeDateHandler : IRequestHandler<GetOrderByRangeDate, IEnumerable<Order>>
{
    private readonly IStoreContext _context;

    public GetOrderByRangeDateHandler(IStoreContext context)
        => _context = context;

    public async Task<IEnumerable<Order>> Handle(GetOrderByRangeDate request, CancellationToken token)
    {
        return await _context.Orders
            .Where(c => c.Created.Date >=  request.Init.Date && c.Created.Date <= request.End.Date )
            .ToListAsync();
    }
}