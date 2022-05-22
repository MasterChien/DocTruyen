using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;


namespace DocTruyen.DataAccess.Extensions
{
    public static class ReplySeedingData
    {
        public static void SeedReplies(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reply>().HasData(
                new Reply
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    Text = "Đồng quan điểm",
                    UserId = 3,
                    CommentId = 1
                },
                new Reply
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    Text = "Bạc quan điểm",
                    UserId = 1,
                    CommentId = 1
                },
                new Reply
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    Text = "Truyện như lone",
                    UserId = 3,
                    CommentId = 3
                });
        }
    }
}
