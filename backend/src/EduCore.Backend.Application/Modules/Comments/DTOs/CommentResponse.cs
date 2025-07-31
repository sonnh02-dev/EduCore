using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Module.Comments.DTOs
{
    public  class CommentResponse

    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public int NumberOfLikes { get; set; }
        public string CreatorName { get; set; } = null!;
        public string CreatorImg { get; set; } = null!;

        public DateTime CreatedAt { get; set; }
        public DateTime? ModifierName { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public int NumberOfReplies { get; set; }


    }
}
