using AutoMapper;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.IRepository;
using DocTruyen.Service.VMs.Chapter;
using Microsoft.AspNetCore.Mvc;

namespace DocTruyen.Areas.User.Controllers
{
    public class ChaptersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ChaptersController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Create(int id)
        {
            var novel = await _unitOfWork.Novels.GetAysnc(n => n.Id == id);
            if (novel == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy truyện";
                return View("NotFound");
            }
            var model = new CreateChapterVM { NovelName = novel.Name,NovelId = novel.Id };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(int id, CreateChapterVM createChapter)
        {
            var novel = await _unitOfWork.Novels.GetAysnc(n => n.Id == id);
            if (novel == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy truyện";
                return View("NotFound");
            }
            var user = await _unitOfWork.UserManagers.GetUserAsync(User);
            if(user == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy người dùng này";
                return View("NotFound");
            }
            createChapter.PublisherId = user.Id;
            createChapter.NovelId = novel.Id;
            createChapter.CreatedDate = DateTime.Now;
            if (!ModelState.IsValid) return View(createChapter);
            var chapter = _mapper.Map<Chapter>(createChapter);

            await _unitOfWork.Chapters.AddAsync(chapter);
            await _unitOfWork.SaveAsync();

            return View();
        }
    }
}
