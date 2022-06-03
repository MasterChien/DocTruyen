
using DocTruyen.Service.VMs.Role;
using DocTruyen.Service.VMs.User;

namespace DocTruyen.Service.Vms.UserRole
{
    public class CreateUserRoleVM
    {
        public CreateUserRoleVM()
        {
            SelectedRoles = new List<SelectedRoleVM>();
        }
        public UserVM User { get; set; }
        public List<SelectedRoleVM> SelectedRoles { get; set; }
        //public List<RoleVM> Roles { get; set; }
    }
}
