using DocTruyen.Service.Helpers;
using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;

namespace DocTruyen.Service.Repository
{
    public class ImgbbService : IImgbbService
    {
        private readonly string _apiKey;
        public ImgbbService(IOptions<ImgbbSettings> config)
        {
            _apiKey = "?key=" + config.Value.ApiKey;
        }
        public async Task<ImgbbUploadResult> UploadImageAsync(IFormFile file)
        {
            if (file.Length > 0)
            {
                var filePath = Path.GetTempFileName();

                using (var stream = System.IO.File.Create(filePath))
                {
                    await file.CopyToAsync(stream);
                }
                byte[] bytes = Convert.FromBase64String(filePath);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://api.imgbb.com/1/upload");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.PostAsJsonAsync(_apiKey, bytes);

                }
            }
            


            //var uploadResult = new ImgbbUploadResult();
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://api.imgbb.com/1/upload");
            //client.DefaultRequestHeaders.Accept.Add(
            //new MediaTypeWithQualityHeaderValue("application/json"));
           

        }
    }
}
