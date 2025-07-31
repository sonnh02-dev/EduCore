using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Common.ValueObjects
{
    public sealed class Rating : ValueObject
    {
        public double Value { get; }

        private Rating(double value)
        {
            Value = Math.Round(value, 1);
        }

        public static Result<Rating> Create(double value)
        {
            if (value < 0 || value > 5)
            {
                return Result<Rating>.Failure(Error.Validation("Rating.Invalid", "Rating must be between 0 and 5!"));
            }

            return Result<Rating>.Success(new Rating(value));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString("0.0");
    }

}
