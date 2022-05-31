using DocTruyen.DataAccess.Enums;
using DocTruyen.Service.DTOs.Chapter;
using DocTruyen.Service.DTOs.Comment;

namespace DocTruyen.Service.DTOs.Novels
{
    public class NovelDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string ImgUrl { get; set; }
        public string Categoty { get; set; }
        public string Desciption { get; set; }
        public NovelStatus Status { get; set; }
        public double Rating { get; set; }
        public List<CommentDTO> Comments { get; set; }
        public List<ChapterDTO> Chapters { get; set; }

    }
}
