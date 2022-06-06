using DocTruyen.Service.VMs.Author;
using DocTruyen.Service.VMs.Category;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.VMs.Novels
{
    public class UploadNovelVM
    {
        [Display(Name ="Tên truyện")]
        [Required(ErrorMessage ="Không được để trống tên truyện")]
        public string Name { get; set; }

        [Display(Name = "Ảnh bìa")]
        public IFormFile Image { get; set; }

        public  List<AuthorViewModel> Authors { get; set; }

        public int AuthorId { get; set; }

        [Display(Name = "Tên tác giả")]
        [Required(ErrorMessage ="Không được để trống tên tác giả")]
        public string AuthorName { get; set; }

        [Display(Name = "Giới thiệu về tác giả")]
        public string AuthorDescription{ get; set; }

        public  List<CategoryVM> Categories { get; set; }

        [Display(Name = "Thể loại")]
        public int CategoryId { get; set; }

        [Display(Name = "Tác giả")]
       
        public int PublisherId { get; set; }

        [Display(Name = "Giới thiệu")]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsExsitAuthor { get; set; } = true;

    }
}
