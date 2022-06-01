using DocTruyen.Service.VMs.Novels;
using Microsoft.AspNetCore.Http;

namespace DocTruyen.Service.VMs.Image
{
    public class ImageUploadVM
    {
        public string PublicId { get; set; }
        public string Caption { get; set; }
        public int FileSize { get; set; }
        public IFormFile Image { get; set; }

        public int NovelId { get; set; }
        public NovelVM Novel { get; set; }
    }
}
