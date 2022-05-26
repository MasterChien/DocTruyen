namespace DocTruyen.DataAccess.Models
{
    public class Image
    {
        #region Properties
        public int Id { get; set; }
        public string PublicId { get; set; }
        public string Caption { get; set; }
        public int FileSize { get; set; }
        public string ImagePath { get; set; }
        #endregion

        #region RelationShips
        public int NovelId { get; set; }
        public Novel Novel { get; set; }
        //public int? AuthorId { get; set; }
        //public Author Author { get; set; }
        #endregion
    }
}
