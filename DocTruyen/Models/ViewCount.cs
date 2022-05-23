using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DocTruyen.DataAccess.Models
{
    public class ViewCount
    {
        [Key]
        public int Id { get; set; }
        [DefaultValue(0)]
        public int DayCount { get; set; }

        [DefaultValue(0)]
        public int WeekCount { get; set; }

        [DefaultValue(0)]
        public int MonthCount { get; set; }

        [DefaultValue(0)]
        public int YearCount { get; set; }

        [DefaultValue(0)]
        public int OverallCount { get; set; }

        //Relationship
        public int NovelId { get; set; }
        public Novel Novel { get; set; }
    }
}
