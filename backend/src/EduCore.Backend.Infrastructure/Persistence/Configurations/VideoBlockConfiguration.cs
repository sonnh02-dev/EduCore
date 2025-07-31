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
    public class VideoBlockConfiguration : IEntityTypeConfiguration<VideoBlock>
    {
        public void Configure(EntityTypeBuilder<VideoBlock> builder)
        {
            builder.Property(vb => vb.VideoUrl).HasMaxLength(1000);
            builder.Property(vb => vb.DurationInSeconds);
            builder.HasData(
                  new VideoBlock
                  {
                      Id = 2,
                      LectureId = 1,
                      ContentType = "Video",
                      Title = "Intro Video",
                      VideoUrl = "https://www.youtube.com/embed/html_intro",
                      DurationInSeconds = 120,
                      Position = 2
                  }
              );
        }
    }
}
