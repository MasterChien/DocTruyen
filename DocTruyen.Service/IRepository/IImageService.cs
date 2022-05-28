using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace DocTruyen.Service.IRepository
{
    public interface IImageService
    {
        Task<ImageUploadResult> AddImageAsync(IFormFile file);
        Task<DeletionResult> DeleteImageAsync(string publicID);
    }
}
