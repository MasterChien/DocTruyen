using DocTruyen.Service.Vms.UserRole;
using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.VMs.User
{
    public class UserVM
    {
        public UserVM()
        {
            Roles = new List<string>();
        }
        public int Id { get; set; }
        [Display(Name="Tên đăng nhập")]
        public string UserName { get; set; }

        public string Email { get; set; }
        [Display(Name ="Ảnh đại diện")]
        public string ProfileImgURL { get; set; }
        [Display(Name ="Phân quyền")]
        public List<string> Roles { get; set; }
    }
}
