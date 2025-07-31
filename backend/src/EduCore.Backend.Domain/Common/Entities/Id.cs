using System;

namespace EduCore.BackEnd.Domain.Common.Entities
{
    public sealed record Id<TEntity>
    {
        public int Value { get; init; }

        public Id(int value)
        {
            if (value <= 0)
                throw new ArgumentException("ID must be a positive non-zero integer.", nameof(value));

            Value = value;
        }

        public Id() { }

        public static Id<TEntity> FromInt(int id) => new(id);

        public static implicit operator int(Id<TEntity> id) => id.Value;

        public static implicit operator Id<TEntity>(int id) => new(id);

        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
    }
}
