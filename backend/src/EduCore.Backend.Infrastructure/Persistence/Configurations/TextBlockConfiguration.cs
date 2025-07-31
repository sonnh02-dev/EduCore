using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class TextBlockConfiguration : IEntityTypeConfiguration<TextBlock>
    {
        public void Configure(EntityTypeBuilder<TextBlock> builder)
        {
            builder.Property(t => t.TextContent)
                .HasMaxLength(2000);
            builder.HasData(
                new TextBlock
                {
                    Id = 1,
                    LectureId = 1,
                    ContentType = "Text",
                    Title = "HTML Overview",
                    TextContent = "HTML stands for HyperText Markup Language...",
                    Position = 1
                },
                new TextBlock
                {
                    Id = 3,
                    LectureId = 2,
                    ContentType = "Text",
                    Title = "Tag Examples",
                    TextContent = "<p>Hello World</p>",
                    Position = 1
                },
                new TextBlock
                {
                    Id = 5,
                    LectureId = 3,
                    ContentType = "Text",
                    Title = "Using Selectors",
                    TextContent = "Selectors let you target elements...",
                    Position = 1
                },
                new TextBlock
                {
                    Id = 6,
                    LectureId = 5,
                    ContentType = "Text",
                    Title = "Data Types",
                    TextContent = "JS has different data types such as string, number...",
                    Position = 1
                }
            );
        }
    }

}
