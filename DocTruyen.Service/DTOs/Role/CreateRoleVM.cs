using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.VMs.Role
{
    public class CreateRoleVM
    {
        [Required(ErrorMessage ="Không được để trống role")]
        [Display(Name ="Phân quyền")]
        public string Name { get; set; }
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
    }
}
