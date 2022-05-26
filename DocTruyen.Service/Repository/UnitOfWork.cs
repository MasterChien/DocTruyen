using AutoMapper;
using DocTruyen.DataAccess.Data;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.IRepository;


namespace DocTruyen.Service.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Constructor
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Public Properties
        public IRepository<AppUser> AppUsers => new Repository<AppUser>(_context);

        public IRepository<AppRole> AppRoles => new Repository<AppRole>(_context);

        public IRepository<Author> Authors => new Repository<Author>(_context);

        public IRepository<Category> Categories => new Repository<Category>(_context);

        public IRepository<Comment> Comments => new Repository<Comment>(_context);

        public IRepository<Chapter> Chapters => new Repository<Chapter>(_context);

        public IRepository<Image> Images => new Repository<Image>(_context);

        public IRepository<Novel> Novels => new Repository<Novel>(_context);

        public IRepository<Reply> Replies => new Repository<Reply>(_context);

        public IRepository<UserReadingLog> UserReadingLogs => new Repository<UserReadingLog>(_context);

        public IRepository<ViewCount> ViewCounts => new Repository<ViewCount>(_context);
        #endregion

        #region Methods
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
