using DocTruyen.Service.Vms.UserRole;
using DocTruyen.Service.VMs.Role;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.VMs.User
{
    public class EditUserVM
    {
 
        public int Id { get; set; }
        [Display(Name="Tên người dùng")]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public IFormFile ProfileImg { get; set; }
        public string PublicImgId { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
