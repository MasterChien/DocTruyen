using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DocTruyen.DataAccess.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        [MaxLength(1000)]
        public string Text { get; set; }

        //Relationship
        public List<Reply> Replies { get; set; }

        public int UserId { get; set; }
        public  AppUser User { get; set; }

        public int NovelId { get; set; }
        public Novel Novel { get; set; }

    }
}
