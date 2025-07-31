using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.SharedKernel;

namespace EduCore.BackEnd.Domain.Common.ValueObjects
{
    public sealed class Description : ValueObject
    {
        public string Value { get; }

        private Description(string value)
        {
            Value = value;
        }

        public static Result<Description> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return Result<Description>.Failure(Error.Validation("Description.Empty", "Description cannot be empty."));

            if (value.Length > 1000)
                return Result<Description>.Failure(Error.Validation("Description.TooLong", "Description must be at most 1000 characters."));

            return Result<Description>.Success(new Description(value));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value;
    }
}
