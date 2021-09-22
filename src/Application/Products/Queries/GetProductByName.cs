namespace Mobnet.Store.Application.Products.Queries;

using MediatR;
using Mobnet.Store.Domain.Entities;
using Mobnet.Store.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

#nullable disable

public class GetProductByName : IRequest<IEnumerable<Product>>
{
    public string Name { get; set; }
}

public class GetProductByNameHandler : IRequestHandler<GetProductByName, IEnumerable<Product>>
{
    private readonly IMediator _mediator;
    private readonly IStoreContext _context;

    public GetProductByNameHandler(IMediator mediator, IStoreContext context)
    {
        _mediator = mediator;
        _context = context;
    }

    public async Task<IEnumerable<Product>> Handle(GetProductByName request, CancellationToken token)
        => await _context.Products.Where(c 
                    => c.Name.Contains(request.Name) || 
                        c.Description.Contains(request.Name))
                        .ToListAsync();
}