using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EduCore.BackEnd.Domain.Common.Enumerations
{
    public abstract class Enumeration<TEnum> : IEquatable<Enumeration<TEnum>>, IComparable
        where TEnum : Enumeration<TEnum>
    {
        public int Value { get; protected init; }
        public string Name { get; protected init; } = string.Empty;
        public string? Description { get; protected init; }

        protected Enumeration(int value, string name, string? description = null)
        {
            Value = value;
            Name = name;
            Description = description;
        }

        public override string ToString() => Name;

        public static IEnumerable<TEnum> Enumerations =>
            typeof(TEnum)
            .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
            .Where(f => f.FieldType == typeof(TEnum))
            .Select(f => f.GetValue(null))
            .Cast<TEnum>();

        public static TEnum? FromValue(int value) => Enumerations.FirstOrDefault(e => e.Value == value);
        public static TEnum? FromName(string name) => Enumerations.FirstOrDefault(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase));

        public static bool IsDefined(int value) => FromValue(value) is not null;
        public static bool IsDefined(string name) => FromName(name) is not null;

        public static bool TryFromValue(int value, out TEnum? result)
        {
            result = FromValue(value);
            return result is not null;
        }

        public static bool TryFromName(string name, out TEnum? result)
        {
            result = FromName(name);
            return result is not null;
        }

        public override bool Equals(object? obj) => Equals(obj as Enumeration<TEnum>);

        public bool Equals(Enumeration<TEnum>? other)
        {
            if (other is null) return false;
            return GetType() == other.GetType() && Value == other.Value;
        }

        public override int GetHashCode() => HashCode.Combine(Value, Name);

        public int CompareTo(object? other)
        {
            if (other is null) return 1;
            return Value.CompareTo(((Enumeration<TEnum>)other).Value);
        }

        public static bool operator ==(Enumeration<TEnum>? left, Enumeration<TEnum>? right)
        {
            if (left is null && right is null) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }

        public static bool operator !=(Enumeration<TEnum>? left, Enumeration<TEnum>? right) => !(left == right);
    }
}
