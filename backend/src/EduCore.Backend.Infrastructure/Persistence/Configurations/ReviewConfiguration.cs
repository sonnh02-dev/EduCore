using EduCore.BackEnd.Domain.Aggregates.ReviewAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews", Schemas.Review);

            builder.HasKey(r => r.EnrollmentId).HasName("PK_Reviews_EnrollmentId");

            builder.Property(r => r.EnrollmentId).ValueGeneratedOnAdd();

            builder.Ignore(r => r.Id);

            builder.Ignore(r => r.CreatorId);
      

            builder.Property(r => r.Rating).HasColumnType("decimal(2, 1)");



            builder.HasOne(r => r.Enrollment)
                .WithOne(enr => enr.Review)
                .HasForeignKey<Review>(r => r.EnrollmentId)
                .HasConstraintName("FK_Reviews_Enrollments_EnrollmentId")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Review
                {
                    Id = 1,
                    EnrollmentId = 2,
                    Rating = 4.5m,
                    Content = "Khóa học rất hữu ích!",
                    ReOpen = null
                },
                new Review
                {
                    Id = 2,
                    EnrollmentId = 5,
                    Rating = 4.0m,
                    Content = "Giáo viên giảng dễ hiểu.",
                    ReOpen = null
                },
                new Review
                {
                    Id = 3,
                    EnrollmentId = 6,
                    Rating = 3.5m,
                    Content = "Nội dung hơi ngắn, nhưng vẫn ổn.",
                    ReOpen = null
                },
                new Review
                {
                    Id = 4,
                    EnrollmentId = 7,
                    Rating = 5.0m,
                    Content = "Xuất sắc! Học được rất nhiều.",
                    ReOpen = null
                },
                new Review
                {
                    Id = 5,
                    EnrollmentId = 9,
                    Rating = 4.8m,
                    Content = "Tài liệu đầy đủ và chi tiết.",
                    ReOpen = null
                }
            );

        }
    }
}
