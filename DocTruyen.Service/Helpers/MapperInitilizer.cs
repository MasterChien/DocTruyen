using AutoMapper;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.VMs.Author;
using DocTruyen.Service.VMs.Category;
using DocTruyen.Service.VMs.Chapter;
using DocTruyen.Service.VMs.Comment;
using DocTruyen.Service.VMs.Role;
using DocTruyen.Service.VMs.User;

namespace DocTruyen.Service.Helpers
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Category, CategoryVM>().ReverseMap();
            CreateMap<Category, CreateCategoryVM>().ReverseMap();
            CreateMap<Author, AuthorVM>().ReverseMap();
            CreateMap<Author, CreateAuthorVM>().ReverseMap();
            CreateMap<Author, AuthorViewModel>().ReverseMap();
            CreateMap<Chapter, CreateChapterVM>().ReverseMap();
            CreateMap<Chapter, ChapterVM>().ReverseMap();
            CreateMap<Chapter, ChapterViewVM>().ReverseMap();
            CreateMap<Chapter, NewUpdateChapterVM>().ReverseMap();
            CreateMap<Comment, CommentVM>().ReverseMap();
            CreateMap<Comment, CreateCommentVM>().ReverseMap();
            CreateMap<AppUser, UserVM>().ReverseMap();
            CreateMap<AppRole, RoleVM>().ReverseMap();
            CreateMap<AppRole, EditRoleVM>().ReverseMap();
            CreateMap<AppRole, CreateRoleVM>().ReverseMap();

        }

    }
}
