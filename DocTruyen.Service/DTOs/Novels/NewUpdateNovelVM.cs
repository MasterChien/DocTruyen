using DocTruyen.Service.VMs.Author;
using DocTruyen.Service.VMs.Category;
using DocTruyen.Service.VMs.Chapter;

namespace DocTruyen.Service.VMs.Novels
{
    public class NewUpdateNovelVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryVM Category { get; set; }
        public AuthorViewModel Author { get; set; }
    }
}
