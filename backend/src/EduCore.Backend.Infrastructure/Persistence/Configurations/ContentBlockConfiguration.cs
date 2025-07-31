using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using System.Reflection.Emit;
using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class ContentBlockConfiguration : IEntityTypeConfiguration<ContentBlock>
    {
        public void Configure(EntityTypeBuilder<ContentBlock> builder)
        {
            builder.ToTable("ContentBlocks", Schemas.Course);

            builder.HasKey(cb => cb.Id).HasName("PK_ContentBlocks_Id");

            builder.Property(cb => cb.Id)
                .HasConversion(
                    id => id.Value,
                    value => new Id<ContentBlock>(value)
                )
                .HasColumnName("Id");

            builder.HasIndex(cb => cb.LectureId, "IX_ContentBlocks_LectureId");

            builder.HasDiscriminator<string>("ContentType")
                  .HasValue<TextBlock>("Text")
                  .HasValue<VideoBlock>("Video")
                 .HasValue<ImageBlock>("Image")
                 .HasValue<FileBlock>("File");

            builder.HasOne(cb => cb.Lecture)
                 .WithMany(l => l.ContentBlocks)
                 .HasForeignKey(cb => cb.LectureId);

            builder.Property(cb => cb.Title)
                  .HasMaxLength(255);


            builder.Property(cb => cb.Position)
                  .IsRequired();

            builder.HasOne(cb => cb.Lecture)
                  .WithMany(l => l.ContentBlocks)
                  .HasForeignKey(cb => cb.LectureId)
                  .HasConstraintName("PK_ContentBlocks_LectureId")
                  .OnDelete(DeleteBehavior.Cascade);

            //builder.HasData(
            //     new  ContentBlock 
            //     {
            //         Id = new Id<ContentBlock>(1),
            //         LectureId = 1,
            //         ContentType = "Text",
            //         Title = "HTML Overview",
            //         TextContent = "HTML stands for HyperText Markup Language...",
            //         Position = 1
            //     },
            //     new
            //     {
            //         Id = 2,
            //         LectureId = 1,
            //         ContentType = "Video",
            //         Title = "Intro Video",
            //         VideoUrl = "https://www.youtube.com/embed/html_intro",
            //         Position = 2
            //     },

            //     new
            //     {
            //         Id = 3,
            //         LectureId = 2,
            //         ContentType = "Text",
            //         Title = "Tag Examples",
            //         TextContent = "<p>Hello World</p>",
            //         Position = 1
            //     },
            //     new
            //     {
            //         Id = 4,
            //         LectureId = 2,
            //         ContentType = "Image",
            //         Title = "HTML Tags Image",
            //         ImageUrl = "https://example.com/images/html-tags.png",
            //         Position = 2
            //     },

            //     new
            //     {
            //         Id = 5,
            //         LectureId = 3,
            //         ContentType = "Text",
            //         Title = "Using Selectors",
            //         TextContent = "Selectors let you target elements...",
            //         Position = 1
            //     },

            //     new
            //     {
            //         Id = 6,
            //         LectureId = 5,
            //         ContentType = "Text",
            //         Title = "Data Types",
            //         TextContent = "JS has different data types such as string, number...",
            //         Position = 1
            //     }
            // );

        }
    }

}
