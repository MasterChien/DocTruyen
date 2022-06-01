namespace DocTruyen.DataAccess.Models
{
    public class Category
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region RelationShips
        public Novel Novel { get; set; }
        #endregion

    }
}
