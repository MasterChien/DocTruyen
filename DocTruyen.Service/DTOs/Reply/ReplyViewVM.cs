using DocTruyen.Service.VMs.User;

namespace DocTruyen.Service.VMs.Reply
{
    public class ReplyViewVM
    {
        public int Id { get; set; }
        public int? ParrentId { get; set; }
        public UserVM User { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Text { get; set; }
    }
}
