using DocTruyen.DataAccess.Data;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.IRepository;
using System;
using System.Threading.Tasks;

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

        #region Private properties
        private IRepository<AppRole> _appRoles;
        private IRepository<AppUser> _appUsers;
        private IRepository<Author> _authors;
        private IRepository<Category> _categories;
        private IRepository<Comment> _comments;
        private IRepository<Chapter> _chapters;
        private IRepository<Image> _images;
        private IRepository<Novel> _novel;
        private IRepository<Reply> _replies;
        private IRepository<UserReadingLog> _readingLog;
        private IRepository<ViewCount> _viewCount;
        #endregion

        #region Public Properties
        public IRepository<AppUser> AppUsers => _appUsers ??= new Repository<AppUser>(_context);

        public IRepository<AppRole> AppRoles => _appRoles ??= new Repository<AppRole>(_context);

        public IRepository<Author> Authors => _authors ??= new Repository<Author>(_context);

        public IRepository<Category> Categories => _categories ??= new Repository<Category>(_context);

        public IRepository<Comment> Comments => _comments ??= new Repository<Comment>(_context);

        public IRepository<Chapter> Chapters => _chapters ??= new Repository<Chapter>(_context);

        public IRepository<Image> Images => _images ??= new Repository<Image>(_context);

        public IRepository<Novel> Novels => _novel ??= new Repository<Novel>(_context);

        public IRepository<Reply> Replies => _replies ??= new Repository<Reply>(_context);

        public IRepository<UserReadingLog> UserReadingLogs => _readingLog ??= new Repository<UserReadingLog>(_context);

        public IRepository<ViewCount> ViewCounts => _viewCount ??= new Repository<ViewCount>(_context);
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
