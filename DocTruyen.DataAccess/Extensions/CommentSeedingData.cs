using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DocTruyen.DataAccess.Extensions
{
    public static class CommentSeedingData
    {
        public static void SeedComments(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    Text = "Truyện rất hay",
                    UserId = 2,
                    NovelId = 1
                },
                new Comment
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    Text = "Truyện rất hay",
                    UserId = 3,
                    NovelId = 1
                },
                new Comment
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    Text = "Truyện như lone",
                    UserId = 3,
                    NovelId = 2
                },
                new Comment
                {
                    Id = 4,
                    ParrentId = 1,
                    CreatedDate = DateTime.Now,
                    Text = "Đồng quan điểm",
                    UserId = 2,
                    NovelId = 1
                },
                new Comment
                {
                    Id = 5,
                    ParrentId = 1,
                    CreatedDate = DateTime.Now,
                    Text = "Bạc quan điểm",
                    UserId = 2,
                    NovelId = 1
                },
                new Comment
                {
                    Id = 6,
                    ParrentId = 3,
                    CreatedDate = DateTime.Now,
                    Text = "Vô học",
                    UserId = 3,
                    NovelId = 1
                });
        }
    }
}
