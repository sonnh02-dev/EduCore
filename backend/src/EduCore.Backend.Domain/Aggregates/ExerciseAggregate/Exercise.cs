using System;
using System.Collections.Generic;
using System.Collections;
using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;

namespace EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate
{
    public partial class Exercise : AggregateRoot<Exercise>
    {
        public string Description { get; set; } = null!;
        public float MaxScore { get; set; } = 10;
        public float WeightPercentage { get; set; } = 0;
        public DateTime DueDate { get; set; }
        public int LectureId { get; set; }
        public string? ExerciseUrl { get; set; }
        public string Discriminator { get; set; } = null!;
        public virtual Lecture Lecture { get; set; } = null!;
        public virtual ICollection<Submission>? Submissions { get; set; } = null!;

    }
}
