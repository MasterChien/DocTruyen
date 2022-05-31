using DocTruyen.Service.DTOs.Reply;
using DocTruyen.Service.DTOs.User;

namespace DocTruyen.Service.DTOs.Comment
{
    public class CommentViewDTO
    {
        public int Id { get; set; }
        public UserDTO User { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Text { get; set; }
        public List<ReplyViewDTO> Replies { get; set; }

    }
}
