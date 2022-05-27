using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using X.PagedList;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.DTOs.Author;

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
        public async Task<IActionResult> Index(int? page = 1)
        {
            const int pageSize = 5;
            var pageNumber = page ?? 1;

            var authors = await _unitOfWork.Authors.GetPagedListAsync(pageNumber, pageSize);
            IEnumerable<AuthorViewModel> dto = _mapper.Map<IEnumerable<AuthorViewModel>>(authors);
            IPagedList<AuthorViewModel> pagedDto = new StaticPagedList<AuthorViewModel>(dto, authors.GetMetaData());
            return View(pagedDto);
        }
        #endregion

        #region Create
        //Get
        public IActionResult Create()
        {
            return View();
        }
        //Post: Category
        [HttpPost]
        public async Task<IActionResult> Create(CreateAuthorDTO createAuthorDTO)
        {
            if (!ModelState.IsValid)
                return View(createAuthorDTO);
            Author author = new Author();
            if (createAuthorDTO.ProfileImgUrl!=null)
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
        //Get:Category/id
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

            if (authorDTO.ProfileImgUrl!=null)
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
