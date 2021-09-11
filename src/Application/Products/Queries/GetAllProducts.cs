namespace Mobnet.Store.Application.Products.Queries;

using MediatR;
using Mobnet.Store.Domain.Entities;
using Mobnet.Store.Application.Common.Interfaces;


#nullable disable

public class GetAllProducts : IRequest<IEnumerable<Product>>
{ }

public class GetAllProductsHandler : IRequestHandler<GetAllProducts, IEnumerable<Product>>
{
    private readonly IMediator _mediator;
    private readonly IStoreContext _context;

    public GetAllProductsHandler(IMediator mediator, IStoreContext context)
    {
        _mediator = mediator;
        _context = context;
    }

    public async Task<IEnumerable<Product>> Handle(GetAllProducts request, CancellationToken token)
    {
        return await Task.FromResult(_context.Products.ToList());
    }

}