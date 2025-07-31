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
    public class FileBlockConfiguration : IEntityTypeConfiguration<FileBlock>
    {
        public void Configure(EntityTypeBuilder<FileBlock> builder)
        {
            builder.Property(fb => fb.FileUrl).HasMaxLength(1000);
            builder.Property(fb => fb.FileName).HasMaxLength(255);
        }
    }
}
