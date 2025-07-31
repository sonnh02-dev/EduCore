using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Domain.Common.Entities;

public abstract class Entity<TEntity> : IEquatable<Entity<TEntity>>
{
    protected Entity(Id<TEntity> id)
    {
        Id = id ?? throw new ArgumentNullException(nameof(id));
    }

    protected Entity()
    {
    }

    public Id<TEntity> Id { get;  init; }

    public static bool operator ==(Entity<TEntity>? first, Entity<TEntity>? second)
    {
        if (ReferenceEquals(first, second)) return true;
        if (first is null || second is null) return false;
        return first.Equals(second);
    }

    public static bool operator !=(Entity<TEntity>? first, Entity<TEntity>? second) => !(first == second);

    public bool Equals(Entity<TEntity>? other)
    {
        if (other is null) return false;
        if (GetType() != other.GetType()) return false;

        return Id.Equals(other.Id);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType()) return false;

        return obj is Entity<TEntity> entity && Equals(entity);
    }

    public override int GetHashCode() => Id.GetHashCode() * 41;

    public override string ToString() => $"{GetType().Name} [Id={Id}]";
}
