using System;
using System.Collections.Generic;
using System.Linq;

namespace Mobnet.Store.Domain.Entities;

public class Order : Entity
{
    public Order()
    {
        Id = Guid.NewGuid();
        Items = new List<OrderItem>();
    }

    public decimal Value { get; private set; }
    public virtual ICollection<OrderItem> Items { get; private set; }

    public void AddItem(OrderItem item)
    {
        item.CalculeTotal();
        Items.Add(item);

        ProcessOrderValue();
    }

    public void AddItems(IEnumerable<OrderItem> items)
    {
        foreach (var item in items)
        {
            AddItem(item);
        }
    }

    public void RemoveItem(OrderItem item)
    {
        Items.Remove(item);

        ProcessOrderValue();
    }

    private void ProcessOrderValue()
    {
        Value = Items.Sum(c => c.Total);
    }
}