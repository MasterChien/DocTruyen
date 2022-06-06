using AutoMapper;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.IRepository;
using DocTruyen.Service.VMs.Chapter;
using Microsoft.AspNetCore.Mvc;

namespace DocTruyen.Areas.User.Controllers
{
    [Area("User")]
    public class ChaptersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ChaptersController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Create(int novelId)
        {
            var novel = await _unitOfWork.Novels.GetAysnc(n => n.Id == novelId);
            if (novel == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy truyện";
                return View("NotFound");
            }
            var allChapters = await _unitOfWork.Chapters.GetAllAsync(n => n.NovelId == novelId);
           
            var totalChapter = allChapters.Count();

            var model = new CreateChapterVM
            {
                NovelName = novel.Name,
                NovelId = novel.Id,
                Index = totalChapter + 1,
                PublisherId = (int)novel.PublisherId
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(int novelId, CreateChapterVM createChapter)
        {
            var novel = await _unitOfWork.Novels.GetAysnc(n => n.Id == novelId);
            if (novel == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy truyện";
                return View("NotFound");
            }
            var allChapters = await _unitOfWork.Chapters.GetAllAsync(n => n.NovelId == novelId);

            var totalChapter = allChapters.Count();
            createChapter.CreatedDate = DateTime.Now;
            if (!ModelState.IsValid) return View(createChapter);
            var chapter = _mapper.Map<Chapter>(createChapter);

            await _unitOfWork.Chapters.AddAsync(chapter);
            await _unitOfWork.SaveAsync();

            return View();
        }
    }
}
