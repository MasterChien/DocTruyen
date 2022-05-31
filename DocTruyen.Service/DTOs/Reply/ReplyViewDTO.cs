using DocTruyen.Service.DTOs.User;

namespace DocTruyen.Service.DTOs.Reply
{
    public class ReplyViewDTO
    {
        public int Id { get; set; }
        public int? ParrentId { get; set; }
        public UserDTO User { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Text { get; set; }
    }
}
