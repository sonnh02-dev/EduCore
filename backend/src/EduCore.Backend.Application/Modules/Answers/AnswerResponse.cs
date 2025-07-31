using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.Answers
{
    public class AnswerResponse
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public bool IsCorrect { get; set; }
    }
}
