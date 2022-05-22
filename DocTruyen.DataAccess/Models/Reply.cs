namespace DocTruyen.DataAccess.Models
{
    public class Reply
    {
        #region Properties
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Text { get; set; }
        #endregion

        #region RelationShips
        public int CommentId { get; set; }
        public Comment Comment { get; set; }

        public int UserId { get; set; }
        public AppUser User { get; set; }
        #endregion
    }
}
