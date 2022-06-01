using AutoMapper;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.IRepository;
using DocTruyen.Service.VMs.Role;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DocTruyen.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    [Route("Admin/Role")]
    public class RolesController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public RolesController(/*RoleManager<AppRole> roleManager,*/
            IMapper mapper, /*UserManager<AppUser> userManager*/
            IUnitOfWork unitOfWork)
        {
            //_userManager = userManager;
            //_roleManager = roleManager;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        [HttpGet("CreateRole")]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole(CreateRoleVM roleVM)
        {
            if (ModelState.IsValid)
            {
                AppRole role = new AppRole
                {
                    Name = roleVM.Name,
                    Description = roleVM.Description
                };
                var result = await _unitOfWork.RoleManagers.CreateAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("ListRoles");
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(roleVM);
        }
        [HttpGet("ListRoles")]
        public IActionResult ListRoles()
        {
            var roles = _mapper.Map<IEnumerable<RoleVM>>(_unitOfWork.RoleManagers.Roles);

            return View(roles);
        }
        #region Update
        //Get:Role/id
        [HttpGet("Update")]
        public async Task<IActionResult> Update(string id)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMassage = "dữ liệu không hợp lệ";
                return View("NotFound");
            }
            var role = await _unitOfWork.RoleManagers.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy role này";
                return View("NotFound");
            }
            var model = _mapper.Map<EditRoleVM>(role);
           
            //foreach (var user in _unitOfWork.UserManagers.Users)
            //{
            //    if (await _unitOfWork.UserManagers.IsInRoleAsync(user, role.Name))
            //    {
            //        model.Users.Add(user.UserName);
            //    }
            //}
            return View(model);
        }
        [HttpPost("Update")]
        public async Task<IActionResult> Update(EditRoleVM editRole)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMassage = "dữ liệu không hợp lệ";
                return View("NotFound");
            }
            var role = await _unitOfWork.RoleManagers.FindByIdAsync(editRole.Id);
            if (role == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy role này";
                return View("NotFound");
            }
            else
            {
                role.Name = editRole.Name;
                role.Description = editRole.Description;
                var result = await _unitOfWork.RoleManagers.UpdateAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("ListRoles");
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(editRole);
            }
        }
        #endregion

        #region Delete
        //Get/Role/id
        public async Task<IActionResult> Delete(string id)
        {
            var role = await _unitOfWork.RoleManagers.FindByIdAsync(id);
            if (role == null) return View("NotFound");

            return View(role);
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(string id)
        {
            var role = await _unitOfWork.RoleManagers.FindByIdAsync(id);
            if (role == null) return View("NotFound");

            await _unitOfWork.RoleManagers.DeleteAsync(role);

            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
