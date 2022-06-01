using DocTruyen.Service.Helpers;
using Microsoft.AspNetCore.Http;

namespace DocTruyen.Service.IRepository
{
    public interface IImgbbService
    {
        Task<ImgbbUploadResult> UploadImageAsync(IFormFile file);
    }
}
