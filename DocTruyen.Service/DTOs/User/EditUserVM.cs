using DocTruyen.Service.VMs.Role;
using Microsoft.AspNetCore.Http;

namespace DocTruyen.Service.VMs.User
{
    public class EditUserVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public IFormFile ProfileImg { get; set; }
        public ICollection<RoleVM> Roles { get; set; }
    }
}
