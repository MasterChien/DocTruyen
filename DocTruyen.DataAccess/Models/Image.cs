using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DocTruyen.DataAccess.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Caption { get; set; }
        public int FileSize { get; set; }
        public string ImagePath { get; set; }

        //Relationship
        public int NovelId { get; set; }
        public Novel Novel { get; set; }
    }
}
