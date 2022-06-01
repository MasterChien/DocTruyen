namespace DocTruyen.Service.VMs.Chapter
{
    public class CreateChapterVM
    {
        public string Title { get; set; }
        public int Index { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ContentPath { get; set; }
        public int PublisherId { get; set; }
        public int NovelId { get; set; }
    }
}
