using System.ComponentModel.DataAnnotations;

namespace DocTruyen.ViewModels.Users
{
    public class LoginRequest
    {
        [Required(ErrorMessage ="Email không được để trống")]
        public string Email { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
