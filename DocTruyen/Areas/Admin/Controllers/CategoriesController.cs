using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using DocTruyen.Service.DTOs.Category;
using X.PagedList;
using DocTruyen.DataAccess.Models;

namespace DocTruyen.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        #region Constructor
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoriesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index(int? page = 1)
        {
            const int pageSize = 5;
            var pageNumber = page ?? 1;

            var categories = await _unitOfWork.Categories.GetPagedListAsync(pageNumber, pageSize);
            IEnumerable<CategoryDTO> dto = _mapper.Map<IEnumerable<CategoryDTO>>(categories);
            IPagedList<CategoryDTO> pagedDto = new StaticPagedList<CategoryDTO>(dto, categories.GetMetaData());
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
        [ActionName("Create")]
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDTO createCategoryDTO)
        {
            if (!ModelState.IsValid)
                return View(createCategoryDTO);
            var category = _mapper.Map<Category>(createCategoryDTO);
            await _unitOfWork.Categories.AddAsync(category);
            await _unitOfWork.SaveAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update
        //Get:Category/id
        public async Task<IActionResult> Update(int id)
        {
            var category = await _unitOfWork.Categories.GetAysnc(c => c.Id == id);
            if (category == null) return View("NotFound");
            return View(_mapper.Map<CategoryDTO>(category));
        }

        //Post:Category/id
        [HttpPost]
        public async Task<IActionResult> Update(int id, CategoryDTO categoryDTO)
        {
            if (!ModelState.IsValid) return View(categoryDTO);

            var category = await _unitOfWork.Categories.GetAysnc(c => c.Id == id);
            if (category == null) return View("NotFound");

            _mapper.Map(categoryDTO, category);
            _unitOfWork.Categories.Update(category);
            await _unitOfWork.SaveAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete
        //Get/Category/id
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _unitOfWork.Categories.GetAysnc(c => c.Id == id);
            if (category == null) return View("NotFound");

            return View(category);
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var category = await _unitOfWork.Categories.GetAysnc(c => c.Id == id);
            if (category == null) return View("NotFound");

            await _unitOfWork.Categories.DeleteAsync(id);
            await _unitOfWork.SaveAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
