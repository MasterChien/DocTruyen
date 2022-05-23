using DocTruyen.DataAccess.Models;

namespace DocTruyen.ViewModels.Novel
{
    public class NovelDetailRequest : NovelVM
    {
        public IList<Chapter> Chapters;
        public IList<Comment> Comments { get; set; }
    }
}
