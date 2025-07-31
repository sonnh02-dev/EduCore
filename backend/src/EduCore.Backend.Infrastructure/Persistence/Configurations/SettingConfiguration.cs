using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class SettingConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.ToTable("Settings", Schemas.User);

            builder.HasKey(e => e.Id).HasName("PK_Settings_Id");

            builder.HasIndex(e => e.UserProfileId, "IX_Settings_UserProfileId");


            builder.Property(e => e.Language)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);


            builder.HasOne(d => d.UserProfile)
                .WithMany(p => p.Settings)
                .HasForeignKey(d => d.UserProfileId)
                .HasConstraintName("FK_Settings_UserProfiles_UserId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                 new Setting { Id = 1, UserProfileId = 1, Theme = "Light", Language = "en", NotificationsEnabled = true },
                 new Setting { Id = 2, UserProfileId = 2, Theme = "Dark", Language = "vi", NotificationsEnabled = true },
                 new Setting { Id = 3, UserProfileId = 3, Theme = "Light", Language = "en", NotificationsEnabled = false },
                 new Setting { Id = 4, UserProfileId = 4, Theme = "Dark", Language = "vi", NotificationsEnabled = true },
                 new Setting { Id = 5, UserProfileId = 5, Theme = "Light", Language = "en", NotificationsEnabled = true },
                 new Setting { Id = 6, UserProfileId = 6, Theme = "Dark", Language = "vi", NotificationsEnabled = false },
                 new Setting { Id = 7, UserProfileId = 7, Theme = "Light", Language = "en", NotificationsEnabled = true },
                 new Setting { Id = 8, UserProfileId = 8, Theme = "Dark", Language = "vi", NotificationsEnabled = true },
                 new Setting { Id = 9, UserProfileId = 9, Theme = "Light", Language = "en", NotificationsEnabled = false },
                 new Setting { Id = 10, UserProfileId = 10, Theme = "Dark", Language = "vi", NotificationsEnabled = true }
             );

        }
    }
}
