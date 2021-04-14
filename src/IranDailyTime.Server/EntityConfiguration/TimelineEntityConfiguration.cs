using IranDailyTime.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IranDailyTime.Server.EntityConfiguration
{
    public class TimelineEntityConfiguration :
        IEntityTypeConfiguration<TimelineEntity>
    {
        public void Configure(EntityTypeBuilder<TimelineEntity> builder)
        {
            builder.Property(a => a.Title).IsRequired().HasMaxLength(256);
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Tags).IsRequired().HasMaxLength(1024);
        }
    }
}