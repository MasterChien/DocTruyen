using DocTruyen.Service.DTOs.Author;
using DocTruyen.Service.DTOs.Category;
using DocTruyen.Service.DTOs.Chapter;

namespace DocTruyen.Service.DTOs.Novels
{
    public class NewUpdateNovelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryDTO Category { get; set; }
        public AuthorViewModel Author { get; set; }
    }
}
