//using AutoMapper;
//using DocTruyen.Service.IRepository;
//using DocTruyen.Service.Vms.UserRole;
//using DocTruyen.Service.VMs.Role;
//using DocTruyen.Service.VMs.User;
//using Microsoft.AspNetCore.Mvc;

//namespace DocTruyen.Areas.Admin.Controllers.ViewComponents
//{
//    public class SetUserRolesViewComponent : ViewComponent
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;

//        public SetUserRolesViewComponent(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public async Task<IViewComponentResult> InvokeAsync(int id)
//        {
//            var appUser = await _unitOfWork.AppUsers.GetAysnc(u => u.Id == id, new List<string> { "UserRoles"});

//            var allRoles = await _unitOfWork.AppRoles.GetAllAsync();

//            var createUserRole = new CreateUserRoleVM
//            {
//                User = _mapper.Map<UserVM>(appUser),
//            };
            
//            return View(createUserRole);
//        }
//        [HttpPost]
//        public async Task<IViewComponentResult> InvokeAsync(int id, CreateUserRoleVM createUserRole)
//        {
//            var appUser = await _unitOfWork.AppUsers.GetAysnc(u => u.Id == id);
//            var allRoles = await _unitOfWork.AppRoles.GetAllAsync();

//            var user = await _unitOfWork.UserManagers.FindByIdAsync(appUser.ConcurrencyStamp);
//            //foreach (var item in collection)
//            //{

//            //}

//            return View(createUserRole);
//        }
//    }
//}
