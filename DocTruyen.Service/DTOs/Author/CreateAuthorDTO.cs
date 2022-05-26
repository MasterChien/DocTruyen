using DocTruyen.Service.DTOs.Novel;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.DTOs.Author
{
    public class CreateAuthorDTO
    {
        [Required(ErrorMessage = "Không được để trống tên tác giả")]
        [MaxLength(200, ErrorMessage = "Tên tác giả không được vượt quá 200 ký tự")]
        [Display(Name = "Tên tác giả")]
        public string Name { get; set; }

        [Display(Name = "Giới thiệu")]
        public string Description { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public IFormFile ProfileImgUrl { get; set; }

        //Realationship
        public List<NovelDTO> Novels { get; set; }
    }
}
