using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;


namespace DocTruyen.DataAccess.Extensions
{
    public static class AuthorSeedingData
    {
        public static void SeedAuthors(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    Name = "Ta la Lão Ngũ",
                    Description = "Đây là tác giả cấp Đại thần",
                    ProfileImgUrl = "https://nae.vn/ttv/ttv/public/images_user/10a1c6c931075aba32b7d7bfc986288037785186fce122f2c18a26a9d1c10ff6.jpg"
                },
                new Author
                {
                    Id = 2,
                    Name = "Thần Đông",
                    Description = "Đây là tác giả cấp Đại thần",
                    ProfileImgUrl = "https://nae.vn/ttv/ttv/public/images_user/10a1c6c931075aba32b7d7bfc986288037785186fce122f2c18a26a9d1c10ff6.jpg"
                },
                new Author
                {
                    Id = 3,
                    Name = "Ngã Cật Tây Hồng Thị",
                    Description = "Đây là tác giả cấp Đại thần",
                    ProfileImgUrl = "https://nae.vn/ttv/ttv/public/images_user/10a1c6c931075aba32b7d7bfc986288037785186fce122f2c18a26a9d1c10ff6.jpg"
                });
        }
    }
}
