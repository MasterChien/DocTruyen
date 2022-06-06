using System.ComponentModel.DataAnnotations;

namespace DocTruyen.Service.VMs.Chapter
{
    public class CreateChapterVM
    {
        [Display(Name ="Tên chương")]
        public string Title { get; set; }
        [Display(Name = "Chương thứ: ")]
        public int Index { get; set; }
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Nội dung")]
        public string Content { get; set; }
        public int PublisherId { get; set; }
        public int NovelId { get; set; }
        public string NovelName { get; set; }
    }
}
