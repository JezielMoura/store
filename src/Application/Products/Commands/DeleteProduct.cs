using MediatR;
using Mobnet.Store.Application.Products.Events;
using Mobnet.Store.Application.Common.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Linq;

namespace Mobnet.Store.Application.Products.Commands;

public record DeleteProduct (long Code) : IRequest;

public class DeleteProductHandler : AsyncRequestHandler<DeleteProduct>
{
    private readonly IMediator _mediator;
    private readonly IStoreContext _context;

    public DeleteProductHandler(IMediator mediator, IStoreContext context)
    {
        _mediator = mediator;
        _context = context;
    }
    protected override async Task Handle(DeleteProduct command, CancellationToken token)
    {
        var product = _context.Products.FirstOrDefault(c => c.Code == command.Code);

        if (product is not null)
        {
            _context.Products.Remove(product);
            await _mediator.Publish(new ProductDeleted(){ Name = product.Name, Price = product.Price});
        }

        await _context.SaveChangesAsync(token);
    }

}