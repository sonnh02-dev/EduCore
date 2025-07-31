using System;
using System.Collections.Generic;

namespace EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate
{
    public partial class Question : Entity
    {
        public string Content { get; set; } = null!;
        public int QuizId { get; set; }  
        public virtual Quiz Quiz { get; set; } = null!;

        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
