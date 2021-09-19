using System;

namespace Mobnet.Store.Domain.Entities;

#nullable disable

public class OrderItem : Entity
{
    protected OrderItem() {}
    
    public OrderItem(Guid productId, Guid orderId, decimal price, decimal quantity, decimal maxDiscount, decimal discount)
    {
        ProductId = productId;
        OrderId = orderId;
        Quantity = quantity;
        MaxDiscount = maxDiscount;
        Discount = discount;
        Price = price;
        Quantity = quantity;
        Order = new();
    } 

    public decimal Price { get; private set; }
    public decimal Quantity { get; private set; }
    public decimal Discount { get; private set; }
    public decimal MaxDiscount { get; private set; }
    public decimal Total { get; private set; }
    public Guid ProductId { get; private set; }
    public Guid OrderId { get; private set; }
    public virtual Product Product { get; private set; }
    public virtual Order Order { get; private set; }

    public void ApplyDiscount()
    {
        if (Discount > MaxDiscount) return;

        var discount = (Price * Discount) / 100;

        Price = Price - discount;
    }

    public decimal CalculeTotal()
    {
        ApplyDiscount();

        Total = Quantity * Price;

        return Total;
    }
}
