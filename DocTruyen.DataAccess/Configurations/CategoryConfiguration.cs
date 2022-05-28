using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocTruyen.DataAccess.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasOne(c => c.Novel)
                .WithOne(n => n.Category)
                .HasForeignKey<Novel>(n => n.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
