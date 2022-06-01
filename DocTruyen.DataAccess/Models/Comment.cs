namespace DocTruyen.DataAccess.Models
{
    public class Comment
    {
        #region Properties
        public int Id { get; set; }
        public int? ParrentId { get; set; }
        public List<Comment> Replies { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Text { get; set; }
        #endregion

        #region RelationShips
        //public List<Reply> Replies { get; set; }

        public int UserId { get; set; }
        public AppUser User { get; set; }

        public int NovelId { get; set; }
        public Novel Novel { get; set; }
        #endregion

    }
}
