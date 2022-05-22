using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;


namespace DocTruyen.DataAccess.Extensions
{
    public static class AppRoleSeedingData
    {
        public static void SeedAppRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = 1,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administrator role"
                },
                new AppRole
                {
                    Id = 2,
                    Name = "user",
                    NormalizedName = "user",
                    Description = "user role"
                });
        }
    }
}
