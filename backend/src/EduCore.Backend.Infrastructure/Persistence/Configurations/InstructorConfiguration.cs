using EduCore.BackEnd.Domain.Aggregates.InstructorAggregate;
using EduCore.BackEnd.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors", Schemas.User);
            builder.Ignore(ins => ins.Id);
            builder.HasKey(ins => ins.UserProfileId).HasName("PK_Instructors_UserProfileId");

            builder.HasOne(ins => ins.UserProfile)
                   .WithOne(ip => ip.Instructor)
                   .HasForeignKey<Instructor>(s => s.UserProfileId)
                   .HasConstraintName("FK_Instructors_Profiles_AccountId")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Instructor
                {
                    UserProfileId = 2,
                    Qualifications = "B.Sc. in Computer Science, Certified Web Accessibility Specialist",
                    Specializations = "HTML, CSS, JavaScript, UI/UX",
                    Website = "https://frontendmentor.dev",
                    YearsOfExperience = 6
                },
                new Instructor
                {
                    UserProfileId = 3,
                    Qualifications = "M.Sc. in Software Engineering, React Certification",
                    Specializations = "React, Redux, TypeScript, Next.js",
                    Website = "https://reactwizard.io",
                    YearsOfExperience = 5
                },
                new Instructor
                {
                    UserProfileId = 4,
                    Qualifications = "PhD in Artificial Intelligence",
                    Specializations = "Machine Learning, NLP, Python, TensorFlow",
                    Website = "https://datasciencelab.ai",
                    YearsOfExperience = 8
                },
                new Instructor
                {
                    UserProfileId = 5,
                    Qualifications = "AWS Certified DevOps Engineer, Full Stack Bootcamp Graduate",
                    Specializations = "Node.js, Docker, AWS, MongoDB",
                    Website = "https://devopsfullstack.pro",
                    YearsOfExperience = 7
                }
            );
        }
    }
}
