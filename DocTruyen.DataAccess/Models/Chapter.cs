namespace DocTruyen.DataAccess.Models
{
    public class Chapter
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public int Index { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
        #endregion

        #region RelationShips
        public int PublisherId { get; set; }
        public AppUser Publisher { get; set; }

        public int NovelId { get; set; }
        public Novel Novel { get; set; }
        #endregion
        // public List<UserReadingLog> UserReadingLogs { get; set; }
    }
}
