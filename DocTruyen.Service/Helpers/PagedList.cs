using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace DocTruyen.Service.Helpers
{
    public class PagedList<TResult> : List<TResult>
    {
        #region Properties
        private readonly IMapper _mapper;
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
        #endregion

        #region Constructor
        public PagedList(IEnumerable<TResult> items, int count, int pageNumber, int pageSize, IMapper mapper)
        {
            _mapper = mapper;
            TotalCount = count;
            CurrentPage = pageNumber;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }
        #endregion

        #region Methods
        public async Task<PagedList<TResult>> CreateAsync<TSource>(
        IQueryable<TSource> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(ufc => _mapper.Map<TResult>(ufc))
                .ToListAsync();
            return new PagedList<TResult>(items, count, pageIndex, pageSize,_mapper);
        }

        public async Task<PagedList<TResult>> CreateAsync(
            IQueryable<TResult> source, int pageIndex, int pageSize)
        {
            return await CreateAsync<TResult>(source, pageIndex, pageSize);
        }
        #endregion



    }
}
