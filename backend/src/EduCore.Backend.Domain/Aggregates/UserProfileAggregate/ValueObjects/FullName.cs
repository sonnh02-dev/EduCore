using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.SharedKernel;

namespace EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate.ValueObjects
{
    public sealed class FullName : ValueObject
    {
        public string Value { get; }

        private FullName(string value)
        {
            Value = value;
        }

        public static Result<FullName> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return Result<FullName>.Failure(Error.Validation("FullName.Empty", "Full name cannot be empty."));

            if (value.Length > 100)
                return Result<FullName>.Failure(Error.Validation("FullName.TooLong", "Full name must be at most 100 characters."));

            // Optional: kiểm tra format (chỉ chứa chữ cái, dấu cách,…)
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^[\p{L} \.'\-]+$"))
                return Result<FullName>.Failure(Error.Validation("FullName.Invalid", "Full name contains invalid characters."));

            return Result<FullName>.Success(new FullName(value.Trim()));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value;
    }
}
