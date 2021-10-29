namespace Mobnet.Store.Application.Orders.Commands;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Mobnet.Store.Application.Common.Interfaces;
using Mobnet.Store.Domain.Entities;

public class ProcessOrder : IRequest
{
    public List<OrderItem> Items { get; set; } = new();
    public decimal Valor { get; set;}
}

public class ProcessOrderHandler : AsyncRequestHandler<ProcessOrder>
{
    private readonly IStoreContext _context;

    public ProcessOrderHandler(IStoreContext context)
        => _context = context;

    protected override async Task Handle(ProcessOrder command, CancellationToken token)
    {
        var order = new Order();

        foreach (var item in command.Items)
        {
            var product = _context.Products.Find(item.ProductId);

            if (product is null) return;

            product.RetireStock(item.Quantity);
            _context.Products.Update(product);
            order.AddItem(new OrderItem(product.Id, order.Id, product.Name, product.Price, item.Quantity, product.MaxDiscount, item.Discount));
        }

        _context.Orders.Add(order);

        await _context.SaveChangesAsync(token);
    }
}