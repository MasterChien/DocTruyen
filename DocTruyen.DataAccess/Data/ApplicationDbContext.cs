using DocTruyen.DataAccess.Configurations;
using DocTruyen.DataAccess.Extensions;
using DocTruyen.DataAccess.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DocTruyen.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {   

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //Seed data
            modelBuilder.SeedAuthors();
            modelBuilder.SeedAppRoles();
            modelBuilder.SeedAppUsers();
            modelBuilder.SeedCategories();
            modelBuilder.SeedNovels();
            modelBuilder.SeedChapters();
            modelBuilder.SeedComments();
            modelBuilder.SeedReplies();
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Novel> Novels { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<UserReadingLog> UserReadingLogs { get; set; }
        public DbSet<ViewCount> ViewCounts { get; set; }

    }
}
