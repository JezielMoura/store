using System;

namespace Mobnet.Store.Domain.Entities;

public class Product : Entity
{
    protected Product() 
    {
        Name = string.Empty;
        Description = string.Empty;
    }

    public Product(
        long code,
        string name, 
        string description, 
        decimal stock, 
        decimal stockMin, 
        decimal purchasePrice, 
        decimal price,
        decimal maxDiscount)
    {
        Code = code;
        Name = name;
        Description = description;
        Stock = stock;
        StockMin = stockMin;
        PurchasePrice = purchasePrice;
        Price = price;
        MaxDiscount = maxDiscount;
    }

    public Product(
        Guid id,
        long code,
        string name, 
        string description, 
        int stock, 
        int stockMin, 
        decimal purchasePrice, 
        decimal price,
        decimal maxDiscount
        ) : base (id)
    {
        Code = code;
        Name = name;
        Description = description;
        Stock = stock;
        StockMin = stockMin;
        PurchasePrice = purchasePrice;
        Price = price;
        MaxDiscount = maxDiscount;
    }

    public long Code { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Stock { get; private set; }
    public decimal StockMin { get; private set; }
    public decimal PurchasePrice { get; private set; }
    public decimal Price { get; private set; }
    public decimal MaxDiscount { get; set; }

    public bool LowStock ()
    {
        return Stock <= StockMin;
    }

    public decimal Lucre () 
    {
        return Price - PurchasePrice;
    }

    public void RetireStock(decimal quantity)
    {
        Stock = Stock - quantity;
    }

    public void InsertStock(decimal quantity)
    {
        Stock = Stock + quantity;
    }
}
