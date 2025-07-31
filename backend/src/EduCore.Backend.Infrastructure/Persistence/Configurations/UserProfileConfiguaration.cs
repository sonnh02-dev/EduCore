using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;
using EduCore.BackEnd.Infrastructure.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class UserProfileConfiguaration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)

        {
            builder.ToTable("UserProfiles", Schemas.User);

            builder.HasKey(up => up.UserId).HasName("PK_UserProfiles_UserId");
            builder.Property(up => up.UserId).ValueGeneratedOnAdd();


            builder.HasOne<UserAccount>()
                   .WithOne(ui => ui.UserProfile)
                   .HasForeignKey<UserProfile>(up => up.UserId)
                   .HasConstraintName("FK_UserProfiles_UserIdentities_Id")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new UserProfile
                {
                    UserId = 1,
                    FullName = "Admin User",
                    Address = "System HQ",
                    Bio = "Platform administrator with full access rights.",
                    ImageUrl = "https://example.com/images/admin.jpg"
                },
                new UserProfile
                {
                    UserId = 2,
                    FullName = "John Smith",
                    Address = "123 Instructor Ave",
                    Bio = "Instructor in web development and design.",
                    ImageUrl = "https://example.com/images/instructor1.jpg"
                },
                new UserProfile
                {
                    UserId = 3,
                    FullName = "Jane Doe",
                    Address = "456 Teaching Blvd",
                    Bio = "Experienced instructor in data science and AI.",
                    ImageUrl = "https://example.com/images/instructor2.jpg"
                },
                new UserProfile
                {
                    UserId = 4,
                    FullName = "Michael Brown",
                    Address = "789 Mentor Street",
                    Bio = "Instructor focused on backend technologies.",
                    ImageUrl = "https://example.com/images/instructor3.jpg"
                },
                new UserProfile
                {
                    UserId = 5,
                    FullName = "Emily Johnson",
                    Address = "1010 Code Lane",
                    Bio = "DevOps engineer and cloud solutions instructor.",
                    ImageUrl = "https://example.com/images/instructor4.jpg"
                },
                new UserProfile
                {
                    UserId = 6,
                    FullName = "Alex Nguyen",
                    Address = "202 Student Road",
                    Bio = "Student learning full-stack web development.",
                    ImageUrl = "https://example.com/images/student1.jpg"
                },
                new UserProfile
                {
                    UserId = 7,
                    FullName = "Sophia Le",
                    Address = "303 Student Avenue",
                    Bio = "Student interested in UI/UX and mobile apps.",
                    ImageUrl = "https://example.com/images/student2.jpg"
                },
                new UserProfile
                {
                    UserId = 8,
                    FullName = "William Pham",
                    Address = "404 Study Blvd",
                    Bio = "Student exploring cloud infrastructure and databases.",
                    ImageUrl = "https://example.com/images/student3.jpg"
                },
                new UserProfile
                {
                    UserId = 9,
                    FullName = "Olivia Tran",
                    Address = "505 Academy Street",
                    Bio = "Student specializing in Android and Flutter.",
                    ImageUrl = "https://example.com/images/student4.jpg"
                },
                new UserProfile
                {
                    UserId = 10,
                    FullName = "David Vo",
                    Address = "606 Education Drive",
                    Bio = "Student passionate about AI and machine learning.",
                    ImageUrl = "https://example.com/images/student5.jpg"
                }
            );
        }
    }
}
