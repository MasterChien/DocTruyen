using DocTruyen.DataAccess.Data;
using DocTruyen.Service.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using X.PagedList;

namespace DocTruyen.Service.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region properties
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }
        #endregion

        #region Add
        public async Task AddAsync(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }
        #endregion

        #region Get
        public async Task<T> GetAysnc(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = _db;
            if (includes != null)
            {
                foreach (var includeProperty in includes)
                {
                    query = query.Include(includeProperty);
                }
            }
            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }
        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        {
            IQueryable<T> query = _db;
            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (includes != null)
            {
                foreach (var includeProperty in includes)
                {
                    query = query.Include(includeProperty);
                }
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return await query.AsNoTracking().ToListAsync();
        }
        #endregion
   
        #region Update
        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        #endregion

        #region Delete
        public async Task DeleteAsync(int id)
        {
            var entity = await _db.FindAsync(id);
            _db.Remove(entity);
        }
        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }
        #endregion

        #region Paging
        public async Task<IPagedList<T>> GetPagedListAsync(RequestParams requestParams = null, List<string> includes = null)
        {
            IQueryable<T> query = _db;

            if (includes != null)
            {
                foreach (var includeProperty in includes)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.AsNoTracking().ToPagedListAsync(requestParams.PageNumber, requestParams.PageSize);
        }
        #endregion
    }
}
