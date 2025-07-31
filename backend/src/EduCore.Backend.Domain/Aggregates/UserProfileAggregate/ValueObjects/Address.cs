using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.SharedKernel;

namespace EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate.ValueObjects
{
    public sealed class Address : ValueObject
    {
        public string Value { get; }

        private Address(string value)
        {
            Value = value;
        }

        public static Result<Address> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return Result<Address>.Failure(Error.Validation("Address.Empty", "Address cannot be empty."));

            if (value.Length > 200)
                return Result<Address>.Failure(Error.Validation("Address.TooLong", "Address is too long."));

            return Result<Address>.Success(new Address(value.Trim()));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value;
    }
}
