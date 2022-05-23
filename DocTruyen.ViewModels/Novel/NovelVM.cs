using DocTruyen.DataAccess.Enums;
using DocTruyen.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocTruyen.ViewModels.Novel
{
    public class NovelVM
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được để trống tên truyện")]
        [MaxLength(250, ErrorMessage = "Tên truyện không được vượt qus 250 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không được để trống phần giới thiệu")]
        [MaxLength(1000)]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public NovelStatus Status { get; set; }

        [Column(TypeName = "float(1,1)")]
        public double Rating { get; set; }
        public int TotalChapter { get; set; }

        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int ImageId { get; set; }


    }
}
