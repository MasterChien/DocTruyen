using DocTruyen.Service.DTOs.Home;
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
            List<TrendDTO> trendDTOs = new List<TrendDTO>();
            foreach (var novel in trendNovels)
            {
                var trendDTO = new TrendDTO
                {
                    NovelId = novel.Id,
                    NovelName = novel.Name,
                    TotalChapters = novel.TotalChapter,
                    ShortDes = novel.Description.GetTwentyWords() + "..."
                };
                if (novel.Images.Count > 0)
                {
                    trendDTO.ImagePath = novel.Images.FirstOrDefault().ImagePath;
                }
                else trendDTO.ImagePath = "https://static.cdnno.com/poster/toan-chuc-nghe-thuat-gia/300.jpg?1602252394";
                if (novel.Category != null)
                    trendDTO.Category = novel.Category.Name;
                else
                    trendDTO.Category = "Chưa cập nhật";
                if (novel.Author != null)
                    trendDTO.AuthorName = novel.Author.Name;
                else
                    trendDTO.AuthorName = "Chưa cập nhật";
                trendDTOs.Add(trendDTO);
            }
            return View(trendDTOs);
        }
    }
}
