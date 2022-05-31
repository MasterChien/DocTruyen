using DocTruyen.DataAccess.Models;
namespace DocTruyen.Service.DTOs.Chapter
{
    public class NewUpdateChapterDTO
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public string Title { get; set; }
        public string CreateTime { get; set; }
        public Novel Novel { get; set; }

    }
}
