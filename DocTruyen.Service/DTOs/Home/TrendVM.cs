using DocTruyen.Service.VMs.Image;

namespace DocTruyen.Service.VMs.Home
{
    public class TrendVM
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
