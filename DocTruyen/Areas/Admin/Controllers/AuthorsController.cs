using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using X.PagedList;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.VMs.Author;
using Microsoft.AspNetCore.Authorization;
using DocTruyen.Service.Helpers;

namespace DocTruyen.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorsController : Controller
    {
        #region Constructor
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        public AuthorsController(IUnitOfWork unitOfWork, IMapper mapper, IImageService imageService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _imageService = imageService;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index(int page)
        {
            page = page < 1 ? 1 : page;

            var pagedAuthors = await _unitOfWork.Authors.GetPagedListAsync(null, null, page, 1);
            IEnumerable<AuthorViewModel> VM = _mapper.Map<IEnumerable<AuthorViewModel>>(pagedAuthors);
            IPagedList<AuthorViewModel> pagedVM = new StaticPagedList<AuthorViewModel>(VM, pagedAuthors.GetMetaData());

            return View(pagedVM);
        }
        [HttpPost]
        [HttpGet]
        public async Task<IActionResult> Search(int page, string keyWord)
        {
            const int pageSize = 5;
            page = page < 1 ? 1 : page;

            if (!string.IsNullOrEmpty(keyWord))
            {
                var allAuthors = await _unitOfWork.Authors.GetAllAsync();
                var authors = allAuthors.Where(a => a.Name.RemoveVietnameseSign().ToLower().Contains(keyWord.RemoveVietnameseSign().ToLower()));
                var viewmodel = _mapper.Map<IEnumerable<AuthorViewModel>>(authors);
                IPagedList<AuthorViewModel> pagedModel = new StaticPagedList<AuthorViewModel>(viewmodel, page, pageSize, viewmodel.Count());
                return View("Index", pagedModel);
            }
            return RedirectToAction("index");
        }
        #endregion

        #region Create
        //Get
        public IActionResult Create()
        {
            return View();
        }
        //Post: Author
        [HttpPost]
        public async Task<IActionResult> Create(CreateAuthorVM createAuthorVM)
        {
            if (!ModelState.IsValid)
                return View(createAuthorVM);
            Author author = new Author();
            if (createAuthorVM.ProfileImgUrl != null)
            {
                var result = await _imageService.AddImageAsync(createAuthorVM.ProfileImgUrl);
                if (result.Error != null) return View("NotFound");

                author.PublicId = result.PublicId;
                author.ProfileImgUrl = result.SecureUrl.AbsoluteUri;
            }
            author.Name = createAuthorVM.Name;
            author.Description = createAuthorVM.Description;


            await _unitOfWork.Authors.AddAsync(author);
            await _unitOfWork.SaveAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update
        //Get:Author/id
        public async Task<IActionResult> Update(int id)
        {
            var author = await _unitOfWork.Authors.GetAysnc(a => a.Id == id, new List<string> { "Novels" });
            if (author == null) return View("NotFound");
            var authorVM = new AuthorVM
            {
                Id = author.Id,
                Name = author.Name,
                Description = author.Description
            };
            return View(authorVM);
        }

        //Post:Auhtor/id
        [HttpPost]
        public async Task<IActionResult> Update(int id, AuthorVM authorVM)
        {
            if (!ModelState.IsValid) return View(authorVM);

            var author = await _unitOfWork.Authors.GetAysnc(c => c.Id == id, new List<string> { "Novels" });
            if (author == null) return View("NotFound");

            
            if (authorVM.ProfileImgUrl != null)
            {
                var result = await _imageService.AddImageAsync(authorVM.ProfileImgUrl);
                if (result.Error != null) return View("NotFound");
                author.PublicId = result.PublicId;
                author.ProfileImgUrl = result.SecureUrl.AbsoluteUri;

            }
            author.Name = authorVM.Name;
            author.Description = authorVM.Description;

            _unitOfWork.Authors.Update(author);
            await _unitOfWork.SaveAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Search
        //[AllowAnonymous]
        //public async Task<IActionResult> Search(int page, string keyWord)
        //{
        //    if (!string.IsNullOrEmpty(keyWord)) return View();

        //    ViewData["keyWord"] = keyWord;
        //    var authors = await _unitOfWork.Authors.GetAllAsync(a => a.Name.Contains(keyWord));

        //    var viewmodel = _mapper.Map<IEnumerable<AuthorViewModel>>(authors);
        //    //var models = authors.Select(a =>
        //    //{
        //    //    return _mapper.Map<AuthorViewModel>(a);
        //    //});
        //    if (page == 0) page = 1;
        //    IPagedList<AuthorViewModel> pagedVM = new StaticPagedList<AuthorViewModel>(viewmodel, page, 5, viewmodel.Count());

        //    return View("Index", pagedVM);
        //}
        #endregion

        #region Delete
        //Get/Category/id
        public async Task<IActionResult> Delete(int id)
        {
            var author = await _unitOfWork.Authors.GetAysnc(a => a.Id == id);
            if (author == null) return View("NotFound");

            return View(author);
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var author = await _unitOfWork.Authors.GetAysnc(c => c.Id == id);
            if (author == null) return View("NotFound");
            if (author.PublicId != null)
            {
                var result = await _imageService.DeleteImageAsync(author.PublicId);
            }


            await _unitOfWork.Authors.DeleteAsync(id);
            await _unitOfWork.SaveAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
