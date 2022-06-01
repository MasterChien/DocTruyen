using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DocTruyen.DataAccess.Extensions
{
    public static class ImageSeedingData
    {
        public static void SeedImages(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasData(
                new Image
                {
                    Id = 1,
                    ImagePath = "https://cdn.pixabay.com/photo/2018/03/30/15/11/deer-3275594_960_720.jpg",
                    NovelId = 1
                },
                new Image
                {
                    Id = 2,
                    ImagePath = "https://cdn.pixabay.com/photo/2018/03/30/15/11/deer-3275594_960_720.jpg",
                    NovelId = 2
                });
        }
    }
}
