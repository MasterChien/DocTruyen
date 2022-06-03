using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.IRepository;
using AutoMapper;
using DocTruyen.Service.VMs.User;
using X.PagedList;
using DocTruyen.Service.Vms.UserRole;
using DocTruyen.Service.VMs.Role;
using DocTruyen.Service.Helpers;

namespace DocTruyen.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        #region Constructor
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        public UsersController(IUnitOfWork unitOfWork, IMapper mapper, IImageService imageService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _imageService = imageService;
        }
        #endregion

        // GET: Admin/Users
        public async Task<IActionResult> Index(int? page = 1)
        {
            const int pageSize = 5;
            var pageNumber = page ?? 1;

            var users = await _unitOfWork.AppUsers.GetPagedListAsync(null, null, pageNumber, pageSize, new List<string> { "UserRoles" });
           
            IEnumerable<UserVM> vms = _mapper.Map<IEnumerable<UserVM>>(users);
            
            IPagedList<UserVM> pagedVM = new StaticPagedList<UserVM>(vms, users.GetMetaData());
            return View(pagedVM);
        }

        //GET: Admin/Users/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var user = await _unitOfWork.AppUsers.GetAysnc(u => u.Id == id, new List<string> { "UserRoles" });
            if (user == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy người dùng này";
                return View("NotFound");
            }

            var userVM = _mapper.Map<UserVM>(user);
            foreach (var userRole in user.UserRoles)
            {
                if(userRole != null)
                {
                    var role = await _unitOfWork.AppRoles.GetAysnc(r => r.Id == userRole.RoleId);
                    userVM.Roles.Add(role.Name);
                }
            }

            return View(userVM);
        }


        // GET: Admin/Users/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var user = await _unitOfWork.AppUsers.GetAysnc(u => u.Id == id);
            if (user == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy người dùng này";
                return View("NotFound");
            }
            var userVM = _mapper.Map<EditUserVM>(user);
            return View(userVM);
        }

        // POST: Admin/Users/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditUserVM editUser)
        {
            var user = await _unitOfWork.AppUsers.GetAysnc(u => u.Id == id);
            if (user == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy người dùng này";
                return View("NotFound");
            }

            if (ModelState.IsValid)
            {
                if (editUser.ProfileImg != null)
                {
                    var result = await _imageService.AddImageAsync(editUser.ProfileImg);
                    if (result.Error != null) return View("NotFound");
                    user.PublicImgId = result.PublicId;
                    user.ProfileImgURL = result.SecureUrl.AbsoluteUri;
                }
                user.EmailConfirmed = editUser.EmailConfirmed;
                user.UserName = editUser.UserName;

                _unitOfWork.AppUsers.Update(user);
                await _unitOfWork.SaveAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(editUser);
        }
        public async Task<IActionResult> Search(int page, string keyWord)
        {
            const int pageSize = 5;
            page = page < 1 ? 1 : page;

            if (!string.IsNullOrEmpty(keyWord))
            {
                var allUser = await _unitOfWork.AppUsers.GetAllAsync();
                var users = allUser.Where(u => u.UserName.RemoveVietnameseSign()
                .ToLower().Contains(keyWord.RemoveVietnameseSign().ToLower())|| u.Email.Contains(keyWord));
                var viewmodel = _mapper.Map<IEnumerable<UserVM>>(users);
                IPagedList<UserVM> pagedModel = new StaticPagedList<UserVM>(viewmodel, page, pageSize, viewmodel.Count());
                return View("Index", pagedModel);
            }
            return RedirectToAction("index");
        }
        // GET: Admin/Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var appUser = await _unitOfWork.AppUsers.GetAysnc(u => u.Id == id);
            if (appUser == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy người dùng này";
                return NotFound();
            }

            return View(appUser);
        }

        // POST: Admin/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appUser = await _unitOfWork.AppUsers.GetAysnc(u => u.Id == id);
            if (appUser == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy người dùng này";
                return NotFound();
            }
            await _unitOfWork.AppUsers.DeleteAsync(id);
            await _unitOfWork.SaveAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
