using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocTruyen.DataAccess.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasOne(i => i.Novel)
                .WithMany(n => n.Images)
                .HasForeignKey(i => i.NovelId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
