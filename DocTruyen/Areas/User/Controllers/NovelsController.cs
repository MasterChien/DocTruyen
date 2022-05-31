using AutoMapper;
using DocTruyen.Service.DTOs.Chapter;
using DocTruyen.Service.DTOs.Novels;
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
            var novelDetaisDTO = new NovelDetailsDTO
            {
                Id = novel.Id,
                Name = novel.Name,
                Rating = novel.Rating,
                Status = novel.Status,
                Desciption = novel.Description,
            };
            if (novel.Chapters != null)
            {
                novelDetaisDTO.Chapters = _mapper.Map<List<ChapterDTO>>(novel.Chapters);
            }
            if (novel.Author != null)
                novelDetaisDTO.AuthorName = novel.Author.Name;
            else
                novelDetaisDTO.AuthorName = "Chưa cập nhật";
            if (novel.Category != null)
                novelDetaisDTO.Categoty = novel.Category.Name;
            else
                novelDetaisDTO.Categoty = "Chưa cập nhật";
            if (novel.Images != null)
                novelDetaisDTO.ImgUrl = novel.Images.FirstOrDefault().ImagePath;
            else

                novelDetaisDTO.ImgUrl = "https://static.cdnno.com/poster/toan-chuc-nghe-thuat-gia/300.jpg?1602252394";
            return View(novelDetaisDTO);
        }

        public async Task<IActionResult> Read(int id)
        {
            var chapter = await _unitOfWork.Chapters.GetAysnc(c => c.Id == id);
            var nextChapter = await _unitOfWork.Chapters
                .GetAysnc(c => c.NovelId == chapter.NovelId && c.Index == chapter.Index + 1);
            var previousChapter = await _unitOfWork.Chapters
                .GetAysnc(c => c.NovelId == chapter.NovelId && c.Index == chapter.Index - 1);
            var chapterView = _mapper.Map<ChapterViewDTO>(chapter);

            if (nextChapter != null)
                chapterView.NextChapterId = nextChapter.Id;
            if (previousChapter != null)
                chapterView.PreviousChapterId = previousChapter.Id;

            return View(chapterView);
        }

        //public async Task<IActionResult> CreateComment(int NovelId)
    }
}
