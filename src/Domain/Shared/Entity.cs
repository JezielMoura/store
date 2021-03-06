global using Mobnet.Store.Domain.Shared;
using System;

namespace Mobnet.Store.Domain.Shared;

public abstract class Entity
{
    protected Entity() 
    {
        Id = Guid.NewGuid();
    }
    
    protected Entity(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime LastModified { get; set; } = DateTime.UtcNow;

    public override bool Equals(object? obj)
    {
        return obj is Entity entity &&
               Id == entity.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}