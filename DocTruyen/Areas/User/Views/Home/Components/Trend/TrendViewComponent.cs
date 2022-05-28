using DocTruyen.Service.DTOs.Home;
using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace DocTruyen.Areas.User.Views.Home.Components.Trend
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
            var allNovels = await _unitOfWork.Novels.GetAllAsync(null, null, new List<string> { "Authors" });
            var trendNovels = allNovels.Take(10).ToList();
            List<TrendDTO> trendDTOs = new List<TrendDTO>();
            foreach (var novel in trendNovels)
            {
                var trendDTO = new TrendDTO
                {
                    NovelId = novel.Id,
                    NovelName = novel.Name,
                    AuthorName = novel.Author.Name,
                    TotalChapters = novel.TotalChapter
                };
                trendDTOs.Add(trendDTO);
            }
            return View(trendDTOs);
        }
    }
}
