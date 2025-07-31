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
    public class ImageBlockConfiguration : IEntityTypeConfiguration<ImageBlock>
    {
        public void Configure(EntityTypeBuilder<ImageBlock> builder)
        {
            builder.Property(ib => ib.ImageUrl).HasMaxLength(1000);
            builder.Property(ib => ib.Caption).HasMaxLength(500);
            builder.HasData(
                  new ImageBlock
                  {
                      Id = 4,
                      LectureId = 2,
                      ContentType = "Image",
                      Title = "HTML Tags Image",
                      ImageUrl = "https://example.com/images/html-tags.png",
                      Caption = "HTML tag reference",
                      Position = 2
                  }
              );
        }
    }
}
