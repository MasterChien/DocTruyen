using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.DTOs.Chapter
{
    public class ChapterViewDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Index { get; set; }
        public int NextChapterId { get; set; }
        public int PreviousChapterId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ContentPath { get; set; }
        public int NovelId { get; set; }

    }
}
