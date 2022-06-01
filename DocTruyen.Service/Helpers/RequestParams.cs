namespace DocTruyen.Service.Helpers
{
    public class RequestParams
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 2;
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
