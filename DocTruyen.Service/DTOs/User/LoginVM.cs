using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.VMs.User
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Không được để trống email")]
        [EmailAddress(ErrorMessage = "Định dạng email không đúng")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Không được để trống mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Ghi nhớ mật khẩu")]
        public bool RememberMe { get; set; }

    }
}
