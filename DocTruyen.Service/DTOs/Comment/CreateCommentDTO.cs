using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.DTOs.Comment
{
    public class CreateCommentDTO
    {
        [Required(ErrorMessage = "Không được để trống bình luận")]
        [MaxLength(1000, ErrorMessage = "Bình luận không được vượt quá 1000 ký tự")]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
        public int NovelId { get; set; }

    }
}
