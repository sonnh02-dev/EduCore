using EduCore.BackEnd.Domain.Aggregates.CommentAggregate;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;
using EduCore.BackEnd.Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments", Schemas.Review);
            builder.HasKey(com => com.Id)
                .HasName("PK_Comments_Id");

            builder.Property(com => com.Id)
                   .HasConversion(
                      id => id.Value,
                      value => new Id<Comment>(value));

            builder.HasIndex(com => new { com.LectureId, com.ParentCommentId, com.CreatedAt, com.CreatorId }, "IX_Comments_LectureId_ParentCommentId_CreatedAt_ProfileId");

            builder.HasOne<Lecture>()
                .WithMany()
                .HasForeignKey(com => com.LectureId)
                .HasConstraintName("FK_Comments_Lectures_Id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(com => com.ParentComment)
                .WithMany(pc => pc.Replies)
                .HasForeignKey(com => com.ParentCommentId)
                .HasConstraintName("FK_Comments_Comments_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<UserProfile>()
                .WithMany()
                .HasForeignKey(com => com.CreatorId)
                 .HasConstraintName("FK_Comments_Profiles_AccountId")
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                // Root comments (ParentCommentId = null)
                new Comment { Id = 1, CreatorId = 2, LectureId = 1, Content = "Great explanation on HTML basics!", NumberOfLikes = 3 },
                new Comment { Id = 2, CreatorId = 3, LectureId = 1, Content = "This was really helpful, thanks!", NumberOfLikes = 5 },
                new Comment { Id = 3, CreatorId = 4, LectureId = 1, Content = "Can you explain more about DOCTYPE?", NumberOfLikes = 1 },
                new Comment { Id = 4, CreatorId = 5, LectureId = 1, Content = "Loved the video example!", NumberOfLikes = 4 },
                new Comment { Id = 7, CreatorId = 2, LectureId = 1, Content = "I'm learning a lot from this lecture!", NumberOfLikes = 6 },
                new Comment { Id = 8, CreatorId = 3, LectureId = 1, Content = "Is there a cheat sheet for HTML tags?", NumberOfLikes = 2 },

                // Replies
                new Comment { Id = 5, CreatorId = 3, LectureId = 1, Content = "Sure, DOCTYPE tells the browser which HTML version you're using.", ParentCommentId = 3, NumberOfLikes = 2 },
                new Comment { Id = 6, CreatorId = 2, LectureId = 1, Content = "Agreed, video really helped.", ParentCommentId = 4, NumberOfLikes = 1 },
                new Comment { Id = 9, CreatorId = 4, LectureId = 1, Content = "You can find many online. W3Schools is great!", ParentCommentId = 8, NumberOfLikes = 3 },
                new Comment { Id = 10, CreatorId = 5, LectureId = 1, Content = "Thanks for the tip!", ParentCommentId = 9, NumberOfLikes = 1 }
            );

        }
    }
}
