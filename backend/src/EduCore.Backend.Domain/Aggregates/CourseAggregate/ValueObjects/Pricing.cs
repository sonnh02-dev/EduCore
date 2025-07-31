using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.SharedKernel;
using System;
using System.Collections.Generic;

namespace EduCore.BackEnd.Domain.Aggregates.CourseAggregate.ValueObjects
{
    public sealed class Pricing : ValueObject
    {
        public decimal Price { get; private set; }
        public decimal? Sale { get; private set; }
        public bool HasDiscount => Sale.HasValue && Sale.Value > 0;
        public bool IsFree => Price == 0;
        public decimal DiscountAmount => HasDiscount ? Price * Sale.Value / 100 : 0;
        public string DisplayPrice => IsFree ? "Free" : $"{GetDiscountedPrice():N0} ₫";

        private Pricing(decimal price, decimal? sale)
        {
            Price = price;
            Sale = sale;
        }

        public static Result<Pricing> Create(decimal price, decimal? sale)
        {
            if (price < 0)
                return Result<Pricing>.Failure(Error.Validation("Price.Invalid", "Price must be greater than 0!", "Price"));

            if (sale is < 0 or > 100)
                return Result<Pricing>.Failure(Error.Validation("Sale.Invalid", "Sale must be between 0 and 100.", "Sale"));

            return Result<Pricing>.Success(new Pricing(price, sale));
        }

        public decimal GetDiscountedPrice() => HasDiscount ? Price - DiscountAmount : Price;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Price;
            yield return Sale;
        }
    }
}
