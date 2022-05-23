using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DocTruyen.DataAccess.Models
{
    public class AppUserVM : IdentityUser<int>
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
