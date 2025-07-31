using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.Domain.Common.ValueObjects;
using EduCore.BackEnd.SharedKernel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Aggregates.CourseAggregate.ValueObjects
{
    public sealed class AggregateRating : ValueObject
    {
        public Rating Rating { get; private set; }
        public int NumberOfRatings { get; private set; }

        private AggregateRating(Rating rating, int numberOfRatings)
        {
            Rating = rating;
            NumberOfRatings = numberOfRatings;
        }

        public static Result<AggregateRating> Create(double newRatingValue, int currentCount, Rating currentRating)
        {
            var newCount = currentCount + 1;
            var total = currentRating.Value * currentCount + newRatingValue;
            var newAverage = Math.Round(total / newCount, 1);

            var ratingResult = Rating.Create(newAverage);
            if (ratingResult.IsFailure)
                return Result<AggregateRating>.Failure(ratingResult.Error);

            return Result<AggregateRating>.Success(new AggregateRating(ratingResult.Value, newCount));
        }

        public static AggregateRating Reset() => new AggregateRating(Rating.Create(0).Value, 0);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Rating;
            yield return NumberOfRatings;
        }
    }

}
