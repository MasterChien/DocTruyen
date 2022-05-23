using System.ComponentModel.DataAnnotations;

namespace DocTruyen.ViewModels.Users
{
    public class UserVM
    {
        public int Id { get; set; }

        [Display(Name ="Tài khoản")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public IList<string> Roles { get; set; }
    }
}
