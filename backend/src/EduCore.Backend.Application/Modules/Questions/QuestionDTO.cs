using EduCore.BackEnd.Application.Modules.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.Questions
{
    public class QuestionDTO
    {
        public int QuestionId { get; set; }
        public string Text { get; set; } = null!;
        public List<AnswerResponse> Answers { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
