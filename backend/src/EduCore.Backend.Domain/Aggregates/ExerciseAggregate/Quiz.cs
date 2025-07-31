using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate
{
    public class Quiz : Exercise
    {
        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    }

}
