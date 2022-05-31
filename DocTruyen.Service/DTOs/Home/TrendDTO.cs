using DocTruyen.Service.DTOs.Image;

namespace DocTruyen.Service.DTOs.Home
{
    public class TrendDTO
    {
        public int NovelId { get; set; }
        public string NovelName { get; set; }
        public string AuthorName { get; set; }
        public int TotalChapters { get; set; }
        public string ShortDes { get; set; }
        public string Category { get; set; }
        public string ImagePath { get; set; }
        //public List<Image> Images { get; set; }
    }
}
