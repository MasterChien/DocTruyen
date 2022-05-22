using DocTruyen.DataAccess.Enums;
using DocTruyen.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DocTruyen.DataAccess.Extensions
{
    public static class NovelSeedingData
    {
        public static void SeedNovels(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Novel>().HasData(
                new Novel
                {
                    Id = 1,
                    Name =  "Thiếu gia bị bỏ rơi",
                    AuthorId = 1,
                    PublisherId = 2,
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                    Status = NovelStatus.OnGoing,
                    Rating = 4.5,
                    Description = "- Từ Địa Cầu xuyên việt tới Dị giới đã thấy nhiều, " +
                                    "nhưng Diệp Mặc của chúng ta lại từ Dị giới xuyên tới Địa Cầu." +
                                    "Điều này còn chưa phải là buồn bực nhất, " +
                                    "để cho Diệp Mặc phát điên chính là cậu nhỏ của hắn bị liệt."
                },
                new Novel
                {
                    Id = 2,
                    Name = "Già Thiên",
                    AuthorId = 2,
                    PublisherId = 3,
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                    Status = NovelStatus.Complete,
                    Rating = 4.5,
                    Description = "Trong vũ trụ bao la, một mảnh tinh hệ sinh diệt, cũng bất quá là sát na pha tạp lưu quang."
                                    + "Ngắm nhìn bầu trời, luôn có loại thương cảm kết cục đã nhất định,"
                                    + "trăm ngàn năm sau ngươi ta ở đâu ? Gia quốc, ánh lửa văn minh,"
                                    + "Địa Cầu, đều chẳng qua là trong thâm không một hạt bụi."
                });
        }
    }
}
