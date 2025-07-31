using EduCore.BackEnd.Domain.Entities;
using EduCore.BackEnd.Infrastructure.Authentication;
using EduCore.BackEnd.Infrastructure.Persistence.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Authentication
{
    internal class AuthenticationConfiguration : IEntityTypeConfiguration<UserAccount>,
                                          IEntityTypeConfiguration<IdentityRole<int>>,
                                          IEntityTypeConfiguration<IdentityUserRole<int>>,
                                          IEntityTypeConfiguration<IdentityUserClaim<int>>,
                                          IEntityTypeConfiguration<IdentityUserLogin<int>>,
                                          IEntityTypeConfiguration<IdentityRoleClaim<int>>,
                                          IEntityTypeConfiguration<IdentityUserToken<int>>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.ToTable("UserAccounts", Schemas.Identity);

            builder.Property(e => e.IsActive)
                .HasDefaultValueSql("((1))");

            builder.HasData(
                new UserAccount { Id = 1, UserName = "admin", NormalizedUserName = "ADMIN", Email = "admin@eduplatform.com", NormalizedEmail = "ADMIN@EDUPLATFORM.COM", EmailConfirmed = true, IsActive = true, SecurityStamp = "A1" },
                new UserAccount { Id = 2, UserName = "instructor.john", NormalizedUserName = "INSTRUCTOR.JOHN", Email = "john@eduplatform.com", NormalizedEmail = "JOHN@EDUPLATFORM.COM", EmailConfirmed = true, IsActive = true, SecurityStamp = "A2" },
                new UserAccount { Id = 3, UserName = "instructor.jane", NormalizedUserName = "INSTRUCTOR.JANE", Email = "jane@eduplatform.com", NormalizedEmail = "JANE@EDUPLATFORM.COM", EmailConfirmed = true, IsActive = true, SecurityStamp = "A3" },
                new UserAccount { Id = 4, UserName = "instructor.mike", NormalizedUserName = "INSTRUCTOR.MIKE", Email = "mike@eduplatform.com", NormalizedEmail = "MIKE@EDUPLATFORM.COM", EmailConfirmed = true, IsActive = true, SecurityStamp = "A4" },
                new UserAccount { Id = 5, UserName = "instructor.emily", NormalizedUserName = "INSTRUCTOR.EMILY", Email = "emily@eduplatform.com", NormalizedEmail = "EMILY@EDUPLATFORM.COM", EmailConfirmed = true, IsActive = true, SecurityStamp = "A5" },
                new UserAccount { Id = 6, UserName = "student.alex", NormalizedUserName = "STUDENT.ALEX", Email = "alex@eduplatform.com", NormalizedEmail = "ALEX@EDUPLATFORM.COM", EmailConfirmed = true, IsActive = true, SecurityStamp = "A6" },
                new UserAccount { Id = 7, UserName = "student.sophia", NormalizedUserName = "STUDENT.SOPHIA", Email = "sophia@eduplatform.com", NormalizedEmail = "SOPHIA@EDUPLATFORM.COM", EmailConfirmed = true, IsActive = true, SecurityStamp = "A7" },
                new UserAccount { Id = 8, UserName = "student.william", NormalizedUserName = "STUDENT.WILLIAM", Email = "william@eduplatform.com", NormalizedEmail = "WILLIAM@EDUPLATFORM.COM", EmailConfirmed = true, IsActive = true, SecurityStamp = "A8" },
                new UserAccount { Id = 9, UserName = "student.olivia", NormalizedUserName = "STUDENT.OLIVIA", Email = "olivia@eduplatform.com", NormalizedEmail = "OLIVIA@EDUPLATFORM.COM", EmailConfirmed = true, IsActive = true, SecurityStamp = "A9" },
                new UserAccount { Id = 10, UserName = "student.david", NormalizedUserName = "STUDENT.DAVID", Email = "david@eduplatform.com", NormalizedEmail = "DAVID@EDUPLATFORM.COM", EmailConfirmed = true, IsActive = true, SecurityStamp = "A10" }
            );

        }


        public void Configure(EntityTypeBuilder<IdentityRole<int>> builder)
        {
            builder.ToTable("Roles",Schemas.Identity);
            builder.HasData(
                new IdentityRole<int> { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole<int> { Id = 2, Name = "Instructor", NormalizedName = "INSTRUCTOR" },
                new IdentityRole<int> { Id = 3, Name = "Student", NormalizedName = "STUDENT" }
            );
        }

        public void Configure(EntityTypeBuilder<IdentityUserRole<int>> builder)
        {
            builder.ToTable("UserRoles", Schemas.Identity);
            builder.Property(ur => ur.UserId).HasColumnName("UserAccountId");
            builder.HasData(
                new IdentityUserRole<int> { UserId = 1, RoleId = 1 },

                new IdentityUserRole<int> { UserId = 2, RoleId = 2 },
                new IdentityUserRole<int> { UserId = 3, RoleId = 2 },
                new IdentityUserRole<int> { UserId = 4, RoleId = 2 },
                new IdentityUserRole<int> { UserId = 5, RoleId = 2 },

                new IdentityUserRole<int> { UserId = 6, RoleId = 3 },
                new IdentityUserRole<int> { UserId = 7, RoleId = 3 },
                new IdentityUserRole<int> { UserId = 8, RoleId = 3 },
                new IdentityUserRole<int> { UserId = 9, RoleId = 3 },
                new IdentityUserRole<int> { UserId = 10, RoleId = 3 }
            );
        }

        public void Configure(EntityTypeBuilder<IdentityUserClaim<int>> builder)
        {

            builder.ToTable("UserClaims", Schemas.Identity);
        }

        public void Configure(EntityTypeBuilder<IdentityUserLogin<int>> builder)
        {
            builder.ToTable("UserLogins",Schemas.Identity);
        }

        public void Configure(EntityTypeBuilder<IdentityRoleClaim<int>> builder)
        {
            builder.ToTable("RoleClaims", Schemas.Identity);
            builder.HasData(
              new IdentityRoleClaim<int> { Id = 1, RoleId = 1, ClaimType = "Permission", ClaimValue = "FullAccess" },
              new IdentityRoleClaim<int> { Id = 2, RoleId = 2, ClaimType = "Permission", ClaimValue = "ManageCourses" },
              new IdentityRoleClaim<int> { Id = 3, RoleId = 3, ClaimType = "Permission", ClaimValue = "EnrollCourses" }
          );
        }

        public void Configure(EntityTypeBuilder<IdentityUserToken<int>> builder)
        {
            builder.ToTable("UserTokens", Schemas.Identity);
        }
    }
}
