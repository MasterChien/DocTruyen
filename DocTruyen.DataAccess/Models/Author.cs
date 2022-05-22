using System.ComponentModel.DataAnnotations;

namespace DocTruyen.DataAccess.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Không được để trống tên tác giả")]
        [MaxLength(200,ErrorMessage ="Tên tác giả không được vượt quá 200 ký tự")]
        [Display(Name ="Tên tác giả")]
        public string Name { get; set; }

        [Display(Name = "Giới thiệu")]
        public string Description { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string ProfileImgUrl { get; set; }

        //Realationship
        public List<Novel> Novels { get; set; }
    }
}
