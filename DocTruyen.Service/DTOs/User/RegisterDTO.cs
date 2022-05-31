using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.DTOs.User
{
    public class RegisterDTO
    {
        [Required(ErrorMessage ="Không được để trống email")]
        [EmailAddress(ErrorMessage = "Định dạng email không đúng")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Mật khẩu")]
        [Required(ErrorMessage = "Không được để trống mật khẩu")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu")]
        [Required(ErrorMessage = "Không được để trống")]
        [Compare("Password",ErrorMessage ="Xác nhận mật khẩu không đúng")]
        public string ConfirmPassword { get; set; }
    }
}
