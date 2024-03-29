﻿using DocTruyen.Service.VMs.Home;
using DocTruyen.Service.Helpers;
using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace DocTruyen.Areas.User.Controllers.ViewComponents
{
    public class TrendViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrendViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var allNovels = await _unitOfWork.Novels.GetAllAsync(null, null, new List<string> { "Author", "Images", "Category" });
            var trendNovels = allNovels.Take(10).ToList();
            List<TrendVM> trendVMs = new List<TrendVM>();
            foreach (var novel in trendNovels)
            {
                var trendVM = new TrendVM
                {
                    NovelId = novel.Id,
                    NovelName = novel.Name,
                    TotalChapters = novel.TotalChapter,
                    ShortDes = novel.Description.GetTwentyWords() + "..."
                };
                if (novel.Images.Count > 0)
                {
                    trendVM.ImagePath = novel.Images.FirstOrDefault().ImagePath;
                }
                else trendVM.ImagePath = "https://static.cdnno.com/poster/toan-chuc-nghe-thuat-gia/300.jpg?1602252394";
                if (novel.Category != null)
                    trendVM.Category = novel.Category.Name;
                else
                    trendVM.Category = "Chưa cập nhật";
                if (novel.Author != null)
                    trendVM.AuthorName = novel.Author.Name;
                else
                    trendVM.AuthorName = "Chưa cập nhật";
                trendVMs.Add(trendVM);
            }
            return View(trendVMs);
        }
    }
}
