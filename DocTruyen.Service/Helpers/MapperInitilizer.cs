using AutoMapper;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.DTOs.Author;
using DocTruyen.Service.DTOs.Category;
using X.PagedList;


namespace DocTruyen.Service.Helpers
{
    public class MapperInitilizer: Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Author, CreateAuthorDTO>().ReverseMap();
           
        }

    }
}
