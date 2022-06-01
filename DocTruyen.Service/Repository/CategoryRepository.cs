using AutoMapper;
using DocTruyen.DataAccess.Data;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.VMs.Category;
using DocTruyen.Service.Helpers;
using DocTruyen.Service.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using X.PagedList;

namespace DocTruyen.Service.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public CategoryRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByNameAsync(string categoryName)
        {
            throw new NotImplementedException();
        }

        public async Task<IPagedList<CategoryVM>> GetCategoriesAsync(RequestParams requestParams = null, List<string> includes = null)
        {
            IQueryable<Category> query = _context.Categories;

            if (includes != null)
            {
                foreach (var includeProperty in includes)
                {
                    query = query.Include(includeProperty);
                }
            }
            var categories = await query.AsNoTracking().ToPagedListAsync(requestParams.PageNumber, requestParams.PageSize);
            return _mapper.Map<IPagedList<CategoryVM>>(categories);
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
