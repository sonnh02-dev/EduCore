using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate
{
    public partial class Answer : AggregateRoot<Answer>
    {
        public string Content { get; set; } = null!;
        public bool IsCorrect { get; set; }
        public int? QuestionId { get; set; }

        public virtual Question? Question { get; set; }
    }
}
