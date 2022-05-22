using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DocTruyen.DataAccess.Models
{
    public class AppUser : IdentityUser<int>
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string ProfileImgURL { get; set; }
        #endregion

        #region RelationShips
        public List<Novel> Novels { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Chapter> Chapters { get; set; }
        public List<Reply> Replies { get; set; }
        public List<UserReadingLog> UserReadingLogs { get; set; }
        #endregion

    }
}
