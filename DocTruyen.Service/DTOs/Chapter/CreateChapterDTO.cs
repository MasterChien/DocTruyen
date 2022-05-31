namespace DocTruyen.Service.DTOs.Chapter
{
    public class CreateChapterDTO
    {
        public string Title { get; set; }
        public int Index { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ContentPath { get; set; }
        public int PublisherId { get; set; }
        public int NovelId { get; set; }
    }
}
