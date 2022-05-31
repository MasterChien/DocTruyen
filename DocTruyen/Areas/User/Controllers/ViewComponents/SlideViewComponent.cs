using DocTruyen.Service.DTOs.Home;
using DocTruyen.Service.Helpers;
using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace DocTruyen.Areas.User.Controllers.ViewComponents
{
    public class SlideViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public SlideViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var allNovels = await _unitOfWork.Novels.GetAllAsync(null, null, new List<string> { "Author" });
            var trendNovels = allNovels.Take(10).ToList();
            List<SlideDTO> trendDTOs = new List<SlideDTO>();
            foreach (var novel in trendNovels)
            {
                var slideDTO = new SlideDTO
                {
                    NovelId = novel.Id,
                    NovelName = novel.Name,
                    TotalChapters = novel.TotalChapter,
                    ShortDes = novel.Description.GetTwentyWords() + "..."
                };
                if (novel.Author != null)
                    slideDTO.AuthorName = novel.Author.Name;
                else
                    slideDTO.AuthorName = @"Chưa cập nhật";
                trendDTOs.Add(slideDTO);
            }
            return View(trendDTOs);
        }
    }
}
