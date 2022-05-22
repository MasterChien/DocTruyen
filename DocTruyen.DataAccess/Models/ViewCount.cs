namespace DocTruyen.DataAccess.Models
{
    public class ViewCount
    {
        #region Properties
        public int Id { get; set; }
        public int DayCount { get; set; }
        public int WeekCount { get; set; }
        public int MonthCount { get; set; }
        public int YearCount { get; set; }
        public int OverallCount { get; set; }
        #endregion

        #region RelationShips
        public int NovelId { get; set; }
        public Novel Novel { get; set; }
        #endregion
    }
}
