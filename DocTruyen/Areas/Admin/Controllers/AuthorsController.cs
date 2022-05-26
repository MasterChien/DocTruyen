using DocTruyen.Service.IRepository;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using DocTruyen.Service.DTOs.Category;
using X.PagedList;
using DocTruyen.DataAccess.Models;

namespace DocTruyen.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
