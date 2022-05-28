using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using X.PagedList;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.DTOs.Author;
using Microsoft.AspNetCore.Authorization;

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
        public async Task<IActionResult> Index(int page, string keyWord)
        {
            const int pageSize = 5;
            page = page < 1?1:page;
            
            if (!string.IsNullOrEmpty(keyWord))
            {
                var authors = await _unitOfWork.Authors.GetAllAsync(a => a.Name.Contains(keyWord));
                var viewmodel = _mapper.Map<IEnumerable<AuthorViewModel>>(authors);
                IPagedList<AuthorViewModel> pagedModel = new StaticPagedList<AuthorViewModel>(viewmodel, page, pageSize, viewmodel.Count());
                return View(pagedModel);
            }

            var pagedAuthors = await _unitOfWork.Authors.GetPagedListAsync(null, page, 1);
            IEnumerable<AuthorViewModel> dto = _mapper.Map<IEnumerable<AuthorViewModel>>(pagedAuthors);
            IPagedList<AuthorViewModel> pagedDto = new StaticPagedList<AuthorViewModel>(dto, pagedAuthors.GetMetaData());

            return View(pagedDto);
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
        public async Task<IActionResult> Create(CreateAuthorDTO createAuthorDTO)
        {
            if (!ModelState.IsValid)
                return View(createAuthorDTO);
            Author author = new Author();
            if (createAuthorDTO.ProfileImgUrl != null)
            {
                var result = await _imageService.AddImageAsync(createAuthorDTO.ProfileImgUrl);
                if (result.Error != null) return View("NotFound");

                author.PublicId = result.PublicId;
                author.ProfileImgUrl = result.SecureUrl.AbsoluteUri;
            }
            author.Name = createAuthorDTO.Name;
            author.Description = createAuthorDTO.Description;


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
            var authorDTO = new AuthorDTO
            {
                Id = author.Id,
                Name = author.Name,
                Description = author.Description
            };
            return View(authorDTO);
        }

        //Post:Category/id
        [HttpPost]
        public async Task<IActionResult> Update(int id, AuthorDTO authorDTO)
        {
            if (!ModelState.IsValid) return View(authorDTO);

            var author = await _unitOfWork.Authors.GetAysnc(c => c.Id == id, new List<string> { "Novels" });
            if (author == null) return View("NotFound");

            if (authorDTO.ProfileImgUrl != null)
            {
                var result = await _imageService.AddImageAsync(authorDTO.ProfileImgUrl);
                if (result.Error != null) return View("NotFound");
                author.PublicId = result.PublicId;
                author.ProfileImgUrl = result.SecureUrl.AbsoluteUri;

            }
            author.Name = authorDTO.Name;
            author.Description = authorDTO.Description;

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
        //    IPagedList<AuthorViewModel> pagedDto = new StaticPagedList<AuthorViewModel>(viewmodel, page, 5, viewmodel.Count());

        //    return View("Index", pagedDto);
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
