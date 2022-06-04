using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.VMs.Chapter
{
    public class ChapterViewVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Index { get; set; }
        public int NextChapterId { get; set; }
        public int PreviousChapterId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
        public int NovelId { get; set; }

    }
}
