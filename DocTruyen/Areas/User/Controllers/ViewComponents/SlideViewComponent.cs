using DocTruyen.Service.VMs.Home;
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
            List<SlideVM> trendVMs = new List<SlideVM>();
            foreach (var novel in trendNovels)
            {
                var slideVM = new SlideVM
                {
                    NovelId = novel.Id,
                    NovelName = novel.Name,
                    TotalChapters = novel.TotalChapter,
                    ShortDes = novel.Description.GetTwentyWords() + "..."
                };
                if (novel.Author != null)
                    slideVM.AuthorName = novel.Author.Name;
                else
                    slideVM.AuthorName = @"Chưa cập nhật";
                trendVMs.Add(slideVM);
            }
            return View(trendVMs);
        }
    }
}
