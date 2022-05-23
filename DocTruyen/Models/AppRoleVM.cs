using Microsoft.AspNetCore.Identity;

namespace DocTruyen.DataAccess.Models
{
    public class AppRoleVM : IdentityRole<int>
    {
        public string Description { get; set; }
    }
}
