using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Module.Comments.DTOs
{

    public class CreateCommentRequest
    {
        public string Content { get; set; } = null!;
        public int CreatorId { get; set; }
        public int LectureId { get; set; }
        public int? ParentCommentId { get; set; }

    }
}