using System;
using System.Collections.Generic;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate;


namespace EduCore.BackEnd.Domain.Aggregates.CategoryAggregate
{
    public partial class SubCategory:Entity
    {     
        public string Name { get; set; } = null!;
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Course> Courses { get; set; }=new List<Course>();
    }
}
