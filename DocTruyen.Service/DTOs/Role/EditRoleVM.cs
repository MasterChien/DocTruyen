namespace DocTruyen.Service.VMs.Role
{
    public class EditRoleVM : CreateRoleVM
    {
        public EditRoleVM()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }
        public List<string> Users { get; set; }
    }
}
