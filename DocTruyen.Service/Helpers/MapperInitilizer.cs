using AutoMapper;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.DTOs.Author;
using DocTruyen.Service.DTOs.Category;
using DocTruyen.Service.DTOs.Chapter;
using DocTruyen.Service.DTOs.Comment;
using DocTruyen.Service.DTOs.User;

namespace DocTruyen.Service.Helpers
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Author, CreateAuthorDTO>().ReverseMap();
            CreateMap<Author, AuthorViewModel>().ReverseMap();
            CreateMap<Chapter, CreateChapterDTO>().ReverseMap();
            CreateMap<Chapter, ChapterDTO>().ReverseMap();
            CreateMap<Chapter, ChapterViewDTO>().ReverseMap();
            CreateMap<Chapter, NewUpdateChapterDTO>().ReverseMap();
            CreateMap<Comment, CommentDTO>().ReverseMap();
            CreateMap<Comment, CreateCommentDTO>().ReverseMap();
            CreateMap<AppUser, UserDTO>().ReverseMap();

        }

    }
}
