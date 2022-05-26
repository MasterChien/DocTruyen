using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.DTOs.Category
{
    public class CreateCategoryDTO
    {
        [Required(ErrorMessage = "Tên thể loại không được để trống")]
        [MaxLength(50, ErrorMessage = "Tên thể loại không được vượt quá 50 ký tự")]
        [Display(Name = "Thể loại")]
        public string Name { get; set; }

        [MaxLength(200, ErrorMessage = "Mô tả không được vượt quá 200 ký tự")]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
    }
}
