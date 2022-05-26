using DocTruyen.Service.DTOs.Novel;
using Microsoft.AspNetCore.Http;

namespace DocTruyen.Service.DTOs.Image
{
    public class ImageUploadDTO
    {
        public string PublicId { get; set; }
        public string Caption { get; set; }
        public int FileSize { get; set; }
        public IFormFile Image { get; set; }

        public int NovelId { get; set; }
        public NovelDTO Novel { get; set; }
    }
}
