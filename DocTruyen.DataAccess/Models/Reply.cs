using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocTruyen.DataAccess.Models
{
    public class Reply
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(1000)]
        public string Text { get; set; }

        // Relationship
        public int CommentId { get; set; }
        public Comment Comment { get; set; }

        public int UserId { get; set; }
        public AppUser User { get; set; }
    }
}
