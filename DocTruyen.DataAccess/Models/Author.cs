namespace DocTruyen.DataAccess.Models
{
    public class Author
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProfileImgUrl { get; set; }
        #endregion

        #region RelationShips
        public List<Novel> Novels { get; set; }
        #endregion
    }
}
