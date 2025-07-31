using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate;
using EduCore.BackEnd.SharedKernel;

namespace EduCore.BackEnd.Domain.Aggregates.SaleAggregate
{
    public class Sale : AggregateRoot<Sale>
    {
        public int CourseId { get; private set; }
        public int DiscountPercent { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public bool IsActive(DateTime now) => now >= StartDate && now <= EndDate;

        public virtual Course Course { get; set; } = null!;

        private Sale() { }

        private Sale(int courseId, int discountPercent, DateTime startDate, DateTime endDate)
        {
            CourseId = courseId;
            DiscountPercent = discountPercent;
            StartDate = startDate;
            EndDate = endDate;
        }

        public static Result<Sale> Create(int courseId, int discountPercent, DateTime startDate, DateTime endDate)
        {
            if (discountPercent is < 0 or > 100)
                return Result<Sale>.Failure(Error.Validation("Sale.DiscountInvalid", "Discount must be between 0 and 100"));

            if (endDate < startDate)
                return Result<Sale>.Failure(Error.Validation("Sale.DateInvalid", "End date must be after start date"));

            var sale = new Sale(courseId, discountPercent, startDate, endDate);

            return Result<Sale>.Success(sale);
        }

    }


}
