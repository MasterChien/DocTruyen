using System.Linq.Expressions;
using X.PagedList;

namespace DocTruyen.Service.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null
            );
        Task<IEnumerable<T>> GetTopAsync(int top = 1,
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null
            );
        Task<IPagedList<T>> GetPagedListAsync(Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int pageNumber = 1, int pageSize = 5,
            List<string> includes = null);
        //Task<PagedList<T>> PagedListAsync(int pageNumber = 1,int pageSize = 5, List<string> includes = null);
        Task<T> GetAysnc(Expression<Func<T, bool>> expression, List<string> includes = null);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task DeleteAsync(int id);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
    }
}
