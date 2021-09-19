namespace Mobnet.Store.Application.Products.Queries;

using MediatR;
using Mobnet.Store.Domain.Entities;
using Mobnet.Store.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

#nullable disable

public class GetProductById : IRequest<Product>
{
    public long Code { get; set; }
}

public class GetProductByIdHandler : IRequestHandler<GetProductById, Product>
{
    private readonly IMediator _mediator;
    private readonly IStoreContext _context;

    public GetProductByIdHandler(IMediator mediator, IStoreContext context)
    {
        _mediator = mediator;
        _context = context;
    }

    public async Task<Product> Handle(GetProductById request, CancellationToken token)
    {
        return await _context.Products.FirstOrDefaultAsync(c => c.Code == request.Code);
    }
}