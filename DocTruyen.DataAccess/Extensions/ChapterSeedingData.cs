using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DocTruyen.DataAccess.Extensions
{
    public static class ChapterSeedingData
    {
        public static void SeedChapters(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chapter>().HasData(
                new Chapter
                {
                    Id = 1,
                    Title = "Mở đầu",
                    Index = 1,
                    NovelId = 1,
                    Content = "Đây là nội dung chương 1",
                    PublisherId = 2,
                    CreatedDate = DateTime.Now
                },
                new Chapter
                {
                    Id = 2,
                    Title = "Bắt đầu mới",
                    Index = 2,
                    NovelId = 1,
                    Content = "Đây là nội dung chương 2",
                    PublisherId = 2,
                    CreatedDate = DateTime.Now
                },
                new Chapter
                {
                    Id = 3,
                    Title = "Tu luyện",
                    Index = 3,
                    NovelId = 1,
                    Content = "Đây là nội dung chương 3",
                    PublisherId = 2,
                    CreatedDate = DateTime.Now
                },
                new Chapter
                {
                    Id = 4,
                    Title = "Mở đầu",
                    Index = 1,
                    NovelId = 2,
                    Content = "Đây là nội dung chương 1 truyện Già Thiên",
                    PublisherId = 3,
                    CreatedDate = DateTime.Now
                });
        }
    }
}
