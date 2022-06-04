using AutoMapper;
using DocTruyen.Service.VMs.Chapter;
using DocTruyen.Service.VMs.Novels;
using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;
using DocTruyen.DataAccess.Models;
using DocTruyen.DataAccess.Enums;
using DocTruyen.Service.VMs.Author;
using DocTruyen.Service.VMs.Category;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using DocTruyen.Service.Helpers;
using DocTruyen.Service.VMs.Home;

namespace DocTruyen.Areas.User.Controllers
{
    [Area("User")]
    public class NovelsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        public NovelsController(IUnitOfWork unitOfWork, IMapper mapper,IImageService imageService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _imageService = imageService;
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
        
        public async Task<IActionResult> UploadNovel()
        {
            UploadNovelVM novelUpload = new UploadNovelVM();
            novelUpload.Authors = _mapper.Map<List<AuthorViewModel>>
                (await _unitOfWork.Authors.GetAllAsync());

            novelUpload.Categories = _mapper.Map<List<CategoryVM>>
              (await _unitOfWork.Categories.GetAllAsync());
            novelUpload.AuthorName = "Chưa cập nhật";
           
            return View(novelUpload);
        }
        [HttpPost]
        public async Task<IActionResult> UploadNovel(UploadNovelVM novelUpload)
        {
            if (!ModelState.IsValid) return View(novelUpload);
            
            Novel novel = new Novel
            {
                Name = novelUpload.Name,
                Description = novelUpload.Description,
                CreatedDate = DateTime.Now,
                //AuthorId = novelUpload.AuthorId,
                CategoryId = novelUpload.CategoryId,
                Status = NovelStatus.OnGoing
            };

            if(novelUpload.IsExsitAuthor)
                novel.AuthorId = novelUpload.AuthorId;
            
            AppUser appUser = await _unitOfWork.UserManagers.GetUserAsync(User);
            novel.PublisherId = appUser.Id;
            
            await _unitOfWork.Novels.AddAsync(novel);
            await _unitOfWork.SaveAsync();

            Image image = new Image();
            if (novelUpload.Image != null)
            {
                var result = await _imageService.AddImageAsync(novelUpload.Image);
                if (result.Error != null)
                {
                    ViewBag.ErrorMassage = "Lỗi upload ảnh";
                    return View("NotFound");
                }
                image.PublicId = result.PublicId;
                image.ImagePath = result.SecureUrl.AbsoluteUri;
                image.Caption = novelUpload.Name;
                image.NovelId = novel.Id;
                await _unitOfWork.Images.AddAsync(image);
                await _unitOfWork.SaveAsync();
            }
            return View(novelUpload);
        }
        //public async Task<IActionResult> CreateComment(int NovelId)
    }
}
