using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DocTruyen.DataAccess.Configurations
{
    public class NovelConfiguration : IEntityTypeConfiguration<Novel>
    {
        public void Configure(EntityTypeBuilder<Novel> builder)
        {
            builder.HasOne(n => n.Publisher)
                .WithMany(u => u.Novels)
                .HasForeignKey(n => n.PublisherId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(n => n.Author)
                .WithMany(a => a.Novels)
                .HasForeignKey(n => n.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
