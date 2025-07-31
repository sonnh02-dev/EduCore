using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;
using EduCore.BackEnd.Domain.Common.Entities;
using System;
using System.Collections.Generic;

namespace EduCore.BackEnd.Domain.Aggregates.CommentAggregate
{
    public  class Comment : AuditableAggregateRoot<Comment>
    {
        public string Content { get; set; } = null!;
        public int NumberOfLikes { get; set; } = 0;
        public int LectureId { get; set; }
        public int? ParentCommentId { get; set; }

        //public virtual Lecture Lecture { get; set; } = null!;
        //public virtual UserProfile CreatorProfile { get; set; } = null!;

        public virtual Comment? ParentComment { get; set; } 
        public virtual ICollection<Comment> Replies { get; set; } = new HashSet<Comment>(); 
    }

}
