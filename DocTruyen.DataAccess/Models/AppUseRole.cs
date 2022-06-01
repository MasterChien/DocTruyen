using Microsoft.AspNetCore.Identity;
namespace DocTruyen.DataAccess.Models
{
    public class AppUseRole : IdentityUserRole<int>
    {
        public AppUser User { get; set; }
        public AppRole Role { get; set; }
    }
}
