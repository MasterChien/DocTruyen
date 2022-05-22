namespace DocTruyen.DataAccess.Models
{
    public class UserReadingLog
    {
        #region Properties
        public int Id { get; set; }
        public int ChapterIndex { get; set; }
        #endregion

        #region RelationShips
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public int NovelId { get; set; }
        public Novel NovelReading { get; set; }
        #endregion
    }
}
