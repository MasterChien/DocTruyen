using DocTruyen.DataAccess.Enums;

namespace DocTruyen.DataAccess.Models
{
    public class Novel
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public NovelStatus Status { get; set; }
        public double Rating { get; set; }
        public int TotalChapter { get; set; }
        #endregion

        #region RelationShips
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PublisherId { get; set; }
        public AppUser Publisher { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ViewCount ViewCount { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Image> Images { get; set; }
        public List<Chapter> Chapters { get; set; }
        public List<UserReadingLog> UserReadingLogs { get; set; }
        #endregion
    }
}
