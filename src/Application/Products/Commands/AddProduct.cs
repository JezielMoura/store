using MediatR;
using Mobnet.Store.Application.Products.Events;
using Mobnet.Store.Domain.Entities;
using Mobnet.Store.Application.Common.Interfaces;
using System.Threading.Tasks;
using System.Threading;

namespace Mobnet.Store.Application.Products.Commands;

public class AddProduct : IRequest
{
    public long Code { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Stock { get; set; }
    public int StockMin { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal Price { get; set; }
    public decimal MaxDiscount { get; set; }

    public Product ToProduct()
    {
        return new Product(Code, Name, Description, Stock, StockMin, PurchasePrice, Price, MaxDiscount);
    }
}

public class AddProductHandler : AsyncRequestHandler<AddProduct>
{
    private readonly IMediator _mediator;
    private readonly IStoreContext _context;

    public AddProductHandler(IMediator mediator, IStoreContext context)
    {
        _mediator = mediator;
        _context = context;
    }
    protected override async Task Handle(AddProduct command, CancellationToken token)
    {
        var product = command.ToProduct();

        _context.Products.Add(product);

        await _context.SaveChangesAsync(token);
        await _mediator.Publish(new ProductCreated(){ Name = command.Name, Price = command.Price});
    }
}