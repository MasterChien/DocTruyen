using DocTruyen.DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace DocTruyen.DataAccess.Extensions
{
    public static class AppUserSeedingData
    {
        public static void SeedAppUsers(this ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = 1,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "masterchienboy@gmail.com",
                    NormalizedEmail = "masterchienboy@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                    SecurityStamp = string.Empty,
                    FirstName = "Chien",
                    LastName = "Hoang Van",
                    Dob = new DateTime(2020, 01, 31),
                    ProfileImgURL = "https://i.imgur.com/stD0Q19.jpg"
                },
                new AppUser
                {
                    Id = 2,
                    UserName = "user1",
                    NormalizedUserName = "user1",
                    Email = "user1@gmail.com",
                    NormalizedEmail = "user1@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                    SecurityStamp = string.Empty,
                    FirstName = "Chien",
                    LastName = "Hoang Van",
                    Dob = new DateTime(2020, 01, 31),
                    ProfileImgURL = "https://i.imgur.com/stD0Q19.jpg"
                },
                 new AppUser
                 {
                     Id = 3,
                     UserName = "user2",
                     NormalizedUserName = "user2",
                     Email = "user2@gmail.com",
                     NormalizedEmail = "user2@gmail.com",
                     EmailConfirmed = true,
                     PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                     SecurityStamp = string.Empty,
                     FirstName = "Chien",
                     LastName = "Hoang Van",
                     Dob = new DateTime(2020, 01, 31),
                     ProfileImgURL = "https://i.imgur.com/xELPaag.jpg"
                 });
        }
    }
}
