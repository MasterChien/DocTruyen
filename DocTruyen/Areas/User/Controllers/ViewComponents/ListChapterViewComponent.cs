using AutoMapper;
using DocTruyen.Service.DTOs.Chapter;
using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace DocTruyen.Areas.User.Controllers.ViewComponents
{
    public class ListChapterViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ListChapterViewComponent(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(int novelId)
        {
            var chapters = await _unitOfWork.Chapters
                .GetAllAsync(c => c.NovelId == novelId,
                c => c.OrderBy(o => o.Index));
            var listChapter = _mapper.Map<IEnumerable<ChapterViewDTO>>(chapters);

            return View(listChapter);
        }
    }
}
