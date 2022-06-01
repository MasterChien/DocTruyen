using Microsoft.AspNetCore.Identity;

namespace DocTruyen.DataAccess.Models
{
    public class AppRole : IdentityRole<int>
    {
        public string Description { get; set; }
        public ICollection<AppUseRole> UserRoles { get; set; }
    }
}
