using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DocTruyen.Service.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IList<T>> GetAllAsync(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null
            );
        //Task<IPagedList<T>> GetPagedListAsync(RequestParam requestParam = null, List<string> includes = null);
        Task<T> GetAysnc(Expression<Func<T, bool>> expression, List<string> includes = null);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task DeleteAsync(int id);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
    }
}
