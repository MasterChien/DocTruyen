using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DocTruyen.DataAccess.Models
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        //Relationship
        public List<Novel> Novels { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Chapter> Chapters { get; set; }
        public List<Reply> Replies { get; set; }
        public List<UserReadingLog> UserReadingLogs { get; set; }

        public string ProfileImgURL { get; set; }
    }
}
