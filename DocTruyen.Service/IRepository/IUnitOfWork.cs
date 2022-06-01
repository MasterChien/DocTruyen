using DocTruyen.DataAccess.Models;
using Microsoft.AspNetCore.Identity;

namespace DocTruyen.Service.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<AppRole> AppRoles { get; }
        IRepository<AppUser> AppUsers { get; }
        IRepository<Author> Authors { get; }
        IRepository<Category> Categories { get; }
        IRepository<Comment> Comments { get; }
        IRepository<Chapter> Chapters { get; }
        IRepository<Image> Images { get; }
        IRepository<Novel> Novels { get; }
        IRepository<UserReadingLog> UserReadingLogs { get; }
        IRepository<ViewCount> ViewCounts { get; }
        RoleManager<AppRole> RoleManagers { get; }
        UserManager<AppUser> UserManagers { get; }

        Task SaveAsync();
    }
}
