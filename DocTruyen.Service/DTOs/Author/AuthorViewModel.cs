using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.VMs.Author
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Tên tác giả")]
        public string Name { get; set; }

        [Display(Name = "Giới thiệu")]
        public string Description { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string ProfileImgUrl { get; set; }

    }
}
