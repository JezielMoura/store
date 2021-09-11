global using Mobnet.Store.Domain.Shared;

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

    public Guid Id { get; protected set; }
    public DateTime Created { get; set; }
    public DateTime LastModified { get; set; }

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