using AutoMapper;
using DocTruyen.Service.VMs.Chapter;
using DocTruyen.Service.VMs.Novels;
using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace DocTruyen.Areas.User.Controllers
{
    [Area("User")]
    public class NovelsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public NovelsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Details(int id)
        {
            var novel = await _unitOfWork.Novels.GetAysnc(n => n.Id == id, new List<string> { "Chapters" });
            if (novel == null) return View("NotFound");
            var novelDetaisVM = new NovelDetailsVM
            {
                Id = novel.Id,
                Name = novel.Name,
                Rating = novel.Rating,
                Status = novel.Status,
                Desciption = novel.Description,
            };
            if (novel.Chapters != null)
            {
                novelDetaisVM.Chapters = _mapper.Map<List<ChapterVM>>(novel.Chapters);
            }
            if (novel.Author != null)
                novelDetaisVM.AuthorName = novel.Author.Name;
            else
                novelDetaisVM.AuthorName = "Chưa cập nhật";
            if (novel.Category != null)
                novelDetaisVM.Categoty = novel.Category.Name;
            else
                novelDetaisVM.Categoty = "Chưa cập nhật";
            if (novel.Images != null)
                novelDetaisVM.ImgUrl = novel.Images.FirstOrDefault().ImagePath;
            else

                novelDetaisVM.ImgUrl = "https://static.cdnno.com/poster/toan-chuc-nghe-thuat-gia/300.jpg?1602252394";
            return View(novelDetaisVM);
        }

        public async Task<IActionResult> Read(int id)
        {
            var chapter = await _unitOfWork.Chapters.GetAysnc(c => c.Id == id);
            var nextChapter = await _unitOfWork.Chapters
                .GetAysnc(c => c.NovelId == chapter.NovelId && c.Index == chapter.Index + 1);
            var previousChapter = await _unitOfWork.Chapters
                .GetAysnc(c => c.NovelId == chapter.NovelId && c.Index == chapter.Index - 1);
            var chapterView = _mapper.Map<ChapterViewVM>(chapter);

            if (nextChapter != null)
                chapterView.NextChapterId = nextChapter.Id;
            if (previousChapter != null)
                chapterView.PreviousChapterId = previousChapter.Id;

            return View(chapterView);
        }

        //public async Task<IActionResult> CreateComment(int NovelId)
    }
}
