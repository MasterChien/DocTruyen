using DocTruyen.DataAccess.Configurations;
using DocTruyen.DataAccess.Extensions;
using DocTruyen.DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DocTruyen.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, int
        , IdentityUserClaim<int>, AppUseRole
        , IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Config
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new NovelConfiguration());
            modelBuilder.ApplyConfiguration(new ChapterConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new UserReadingLogConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());

            //Seed data
            modelBuilder.SeedAuthors();
            modelBuilder.SeedAppRoles();
            modelBuilder.SeedAppUsers();
            modelBuilder.SeedCategories();
            modelBuilder.SeedNovels();
            modelBuilder.SeedChapters();
            modelBuilder.SeedComments();
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Novel> Novels { get; set; }
        public DbSet<UserReadingLog> UserReadingLogs { get; set; }
        public DbSet<ViewCount> ViewCounts { get; set; }

    }
}
