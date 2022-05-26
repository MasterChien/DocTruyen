
using System.ComponentModel.DataAnnotations;

namespace DocTruyen.ViewModels.Categories
{
    public class CategoryVM
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
