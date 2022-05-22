using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocTruyen.DataAccess.Models
{
    public class Chapter
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public int Index { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ContentPath { get; set; }

        //RealationShip
        public int PublisherId { get; set; }
        public AppUser Publisher { get; set; }

        public int NovelId { get; set; }
        public Novel Novel { get; set; }

       // public List<UserReadingLog> UserReadingLogs { get; set; }
    }
}
