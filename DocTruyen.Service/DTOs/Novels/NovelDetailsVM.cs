using DocTruyen.DataAccess.Enums;
using DocTruyen.Service.VMs.Chapter;
using DocTruyen.Service.VMs.Comment;

namespace DocTruyen.Service.VMs.Novels
{
    public class NovelDetailsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string ImgUrl { get; set; }
        public string Categoty { get; set; }
        public string Desciption { get; set; }
        public NovelStatus Status { get; set; }
        public double Rating { get; set; }
        public List<CommentVM> Comments { get; set; }
        public List<ChapterVM> Chapters { get; set; }

    }
}
