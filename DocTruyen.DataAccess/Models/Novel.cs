using DocTruyen.DataAccess.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocTruyen.DataAccess.Models
{
    public class Novel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Không được để trống tên truyện")]
        [MaxLength(250, ErrorMessage ="Tên truyện không được vượt qus 250 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không được để trống phần giới thiệu")]
        [MaxLength(1000)]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public NovelStatus Status { get; set; }

        [Column(TypeName ="float(1,1)")]
        public double Rating { get; set; }
        public int TotalChapter { get; set; }

        //Relationship
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PublisherId { get; set; }
        public AppUser Publisher { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ViewCount ViewCount { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Image> Images { get; set; }
        public List<Chapter> Chapters { get; set; }
        public List<UserReadingLog> UserReadingLogs { get; set; }
    }
}
