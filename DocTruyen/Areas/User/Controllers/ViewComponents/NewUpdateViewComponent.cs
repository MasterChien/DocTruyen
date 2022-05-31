using AutoMapper;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.DTOs.Chapter;
using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace DocTruyen.Areas.User.Controllers.ViewComponents
{
    public class NewUpdateViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NewUpdateViewComponent(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            int top = 10;
            var newChapters = await _unitOfWork.Chapters
                .GetTopAsync(top, null, o =>
                o.OrderByDescending(c => c.CreatedDate), new List<string> { "Novel" });
            var newNovels = new List<Novel>();
            var novelIds = newChapters.SelectMany(c => new List<int> { c.NovelId }).Distinct();
            foreach (var id in novelIds)
            {
                newNovels.Add(await _unitOfWork.Novels
                    .GetAysnc(n => n.Id == id, new List<string> { "Category", "Author" }));
                
            }
            foreach (var chapter in newChapters)
            {
                foreach (var novel in newNovels)
                {
                    if (chapter.NovelId == novel.Id)
                        chapter.Novel = novel;
                }
            }
            var newUpdateChapterDTO = _mapper.Map<List<NewUpdateChapterDTO>>(newChapters);
            foreach (var chapter in newUpdateChapterDTO)
            {
                chapter.CreateTime = TimeBefore(newChapters
                    .Where(c => c.Id == chapter.Id)
                    .FirstOrDefault().CreatedDate);
            }
            return View(newUpdateChapterDTO);
        }

        private string TimeBefore(DateTime then)
        {
            double seconds = DateTime.Now.Subtract(then).TotalSeconds;
            if (seconds < 60) return $"{(int)seconds} giây trước";
            else if (seconds < 3600) return $"{(int)(seconds / 60)} phút trước";
            else if (seconds < 24 * 3600) return $"{(int)(seconds / 3600)} giờ trước";
            else if (seconds < 24 * 30 * 3600) return $"{(int)(seconds / (24 * 3600))} ngày trước";
            else if (seconds < 24 * 365 * 3600) return $"{(int)(seconds / (24 * 30 * 3600))} tháng trước";
            else return $"{(int)(seconds / (24 * 365 * 3600))} năm trước";
        }
    }
}
