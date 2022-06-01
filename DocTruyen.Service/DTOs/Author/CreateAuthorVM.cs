using DocTruyen.Service.VMs.Novels;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.VMs.Author
{
    public class CreateAuthorVM
    {
        [Required(ErrorMessage = "Không được để trống tên tác giả")]
        [MaxLength(200, ErrorMessage = "Tên tác giả không được vượt quá 200 ký tự")]
        [Display(Name = "Tên tác giả")]
        public string Name { get; set; }

        public string PublicId { get; set; }

        [Display(Name = "Giới thiệu")]
        public string Description { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public IFormFile ProfileImgUrl { get; set; }

        //Realationship
        public List<NovelVM> Novels { get; set; }
    }
}
