using DocTruyen.Service.VMs.Reply;
using DocTruyen.Service.VMs.User;

namespace DocTruyen.Service.VMs.Comment
{
    public class CommentViewVM
    {
        public int Id { get; set; }
        public UserVM User { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Text { get; set; }
        public List<ReplyViewVM> Replies { get; set; }

    }
}
