using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocTruyen.DataAccess.Configurations
{
    public class UserReadingLogConfiguration : IEntityTypeConfiguration<UserReadingLog>
    {
        public void Configure(EntityTypeBuilder<UserReadingLog> builder)
        {
            builder.HasOne(ur => ur.User)
                .WithMany(u => u.UserReadingLogs)
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ur => ur.NovelReading)
                .WithMany(n => n.UserReadingLogs)
                .HasForeignKey(ur => ur.NovelId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
