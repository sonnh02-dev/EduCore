using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.Domain.Common.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities
{
    public class ContentBlock : AggregateRoot<ContentBlock>
    {

        public int LectureId { get; set; }

        public int Position { get; set; }
        public Title? Title { get; set; }
        public string ContentType { get; set; } = null!;

        public virtual Lecture Lecture { get; set; } = null!;


    }

    public class TextBlock : ContentBlock
    {
        public string TextContent { get; set; } = null!;
    }

    public class VideoBlock : ContentBlock
    {
        public string VideoUrl { get; set; } = null!;
        public int DurationInSeconds { get; set; }
    }

    public class ImageBlock : ContentBlock
    {
        public string ImageUrl { get; set; } = null!;
        public string? Caption { get; set; }
    }

    public class FileBlock : ContentBlock
    {
        public string FileUrl { get; set; } = null!;
        public string? FileName { get; set; }
    }

}
