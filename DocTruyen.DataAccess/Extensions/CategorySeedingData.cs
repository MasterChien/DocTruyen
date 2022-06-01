using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;


namespace DocTruyen.DataAccess.Extensions
{
    public static class CategorySeedingData
    {
        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Đô thị",
                    Description = "thể loại có bối cảnh tại đô thị hiện đại"
                },
                new Category
                {
                    Id = 2,
                    Name = "Tiên hiệp",
                    Description = "Thể loại tu tiên"
                });
        }
    }
}
