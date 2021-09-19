using MediatR;
using Mobnet.Store.Application.Products.Events;
using Mobnet.Store.Domain.Entities;
using Mobnet.Store.Application.Common.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace Mobnet.Store.Application.Products.Commands;

public class EditProduct : IRequest
{
    public Guid Id { get; set; }
    public long Code { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Stock { get; set; }
    public int StockMin { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal Price { get; set; }
    public decimal MaxDiscount { get; set; }

    public Product ToProduct()
        => new Product(Id, Code, Name, Description, Stock, StockMin, PurchasePrice, Price, MaxDiscount);
}

public class EditProductHandler : AsyncRequestHandler<EditProduct>
{
    private readonly IMediator _mediator;
    private readonly IStoreContext _context;

    public EditProductHandler(IMediator mediator, IStoreContext context)
    {
        _mediator = mediator;
        _context = context;
    }
    protected override async Task Handle(EditProduct command, CancellationToken token)
    {
        var product = command.ToProduct();

        _context.Products.Update(product);

        await _context.SaveChangesAsync(token);
        await _mediator.Publish(new ProductUpdated(){ Name = command.Name, Price = command.Price});
    }
}