﻿using DocTruyen.DataAccess.Models;
using DocTruyen.Service.DTOs.Category;
using DocTruyen.Service.Helpers;
using X.PagedList;

namespace DocTruyen.Service.IRepository
{
    public interface ICategoryRepository 
    {
        Task<Category> GetByIdAsync(int id);
        Task<Category> GetByNameAsync(string categoryName);
        Task<IPagedList<CategoryDTO>> GetCategoriesAsync(RequestParams requestParams = null, List<string> includes = null);
        Task<bool> DeleteAsync(int id);
        void Update(Category category);
    }
}
