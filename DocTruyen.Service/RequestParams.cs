
namespace DocTruyen.Service
{
    public class RequestParams
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; }
        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                PageSize = value > maxPageSize ? maxPageSize : value;
            }
        }
    }
}
