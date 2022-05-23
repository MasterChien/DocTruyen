namespace DocTruyen.DataAccess.Models
{
    public class UserReadingLog
    {
        public int Id { get; set; }
        public int ChapterIndex { get; set; }
        
        //Relationship
        public int UserId { get; set; }
        public AppUserVM User { get; set; }
        public int NovelId { get; set; }
        public Novel NovelReading { get; set; }
    }
}
