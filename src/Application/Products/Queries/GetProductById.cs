namespace Mobnet.Store.Application.Products.Queries;

using MediatR;
using Mobnet.Store.Domain.Entities;
using Mobnet.Store.Application.Common.Interfaces;

#nullable disable

public class GetProductById : IRequest<Product>
{
    public Guid Id { get; set; }
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
        return await Task.FromResult(_context.Products.Find(request.Id));
    }
}