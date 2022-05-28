using Microsoft.AspNetCore.Mvc;

namespace DocTruyen.Areas.Admin.Controllers
{
    public class NovelsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
