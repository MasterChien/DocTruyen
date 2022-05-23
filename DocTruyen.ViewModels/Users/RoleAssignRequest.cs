using DocTruyen.ViewModels.Roles;

namespace DocTruyen.ViewModels.Users
{
    public class RoleAssignRequest
    {
        public int UserId { get; set; }
        public IList<RoleVm> Roles { get; set; }
    }
}
