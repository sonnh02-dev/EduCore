using EduCore.BackEnd.Domain.Common.Entities;
using System;
using System.Collections.Generic;

namespace EduCore.BackEnd.Domain.Aggregates.CategoryAggregate
{
    public class Category : AggregateRoot<Category>
    {
        public string Name { get; set; } = null!;

        public virtual ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    }
}
