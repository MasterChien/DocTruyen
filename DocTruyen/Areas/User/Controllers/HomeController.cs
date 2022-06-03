using DocTruyen.Models;
using DocTruyen.Service.Helpers;
using DocTruyen.Service.IRepository;
using DocTruyen.Service.VMs.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DocTruyen.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Search(string keyWord)
        {
            var allNovels = await _unitOfWork.Novels.GetAllAsync(null,null,new List<string> { "Author","Images"});
            var result = allNovels.Where(n => n.Name.RemoveVietnameseSign()
            .ToLower().Contains(keyWord.RemoveVietnameseSign()
            .ToLower())).ToList();

            var listResult = new List<SlideVM>();
            if (result.Count() > 0)
            {
                foreach (var novel in result)
                {
                    var slideVM = new SlideVM
                    {
                        NovelId = novel.Id,
                        NovelName = novel.Name,
                        TotalChapters = novel.TotalChapter,
                        ShortDes = novel.Description.GetTwentyWords() + "..."
                    };
                    if (novel.Images.Any()) slideVM.ImagePath = novel.Images
                            .Where(i => i.ImagePath != null)
                             .FirstOrDefault().ImagePath;
                    else slideVM.ImagePath = "https://static.cdnno.com/poster/nguoi-tai-than-quy-nhuc-than-vo-han-thoi-dien/300.jpg?1649753583";
                    if (novel.Author != null)
                        slideVM.AuthorName = novel.Author.Name;
                    else
                        slideVM.AuthorName = @"Chưa cập nhật";
                    listResult.Add(slideVM);
                }
            }
            return View(listResult);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}