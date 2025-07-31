using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students", Schemas.User);

            builder.HasKey(std => std.UserProfileId).HasName("PK_Students_UserProfileId");
            builder.Ignore(ins => ins.Id);

            builder.HasOne(std => std.UserProfile)
                   .WithOne(sp=>sp.Student)
                   .HasForeignKey<Student>(std => std.UserProfileId)
                   .HasConstraintName("FK_Students_UserProfiles_UserId")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Student
                {
                    UserProfileId = 6,
                    EducationLevel = "Undergraduate",
                    Interests = "Frontend development, graphic design, and responsive web design.",
                },
                new Student
                {
                    UserProfileId = 7,
                    EducationLevel = "Graduate",
                    Interests = "Database systems, data warehousing, and performance optimization techniques.",
                },
                new Student
                {
                    UserProfileId = 8,
                    EducationLevel = "PhD",
                    Interests = "Artificial Intelligence, deep learning, and ethical AI in education.",
                },
                new Student
                {
                    Id =9,
                    UserProfileId = 9,
                    EducationLevel = "High School",
                    Interests = "Mobile apps, cross-platform development, and game mechanics.",
                },
                new Student
                {
                    UserProfileId = 10,
                    EducationLevel = "College",
                    Interests = "Cybersecurity, ethical hacking, and network architecture.",
                }
            );
        }
    }
}
