using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.IRepository;
using AutoMapper;
using DocTruyen.Service.VMs.User;
using X.PagedList;

namespace DocTruyen.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        #region Constructor
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UsersController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        // GET: Admin/Users
        public async Task<IActionResult> Index(int? page = 1)
        {
            const int pageSize = 5;
            var pageNumber = page ?? 1;

            var users = await _unitOfWork.AppUsers.GetPagedListAsync(null, null, pageNumber, pageSize);
            IEnumerable<UserVM> VM = _mapper.Map<IEnumerable<UserVM>>(users);
            IPagedList<UserVM> pagedVM = new StaticPagedList<UserVM>(VM, users.GetMetaData());
            return View(pagedVM);
        }

        // GET: Admin/Users/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var user = await _unitOfWork.AppUsers.GetAysnc(u => u.Id == id);
            if (user==null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy người dùng này";
                return View("NotFound");
            }

            var userVM = _mapper.Map<UserVM>(user);

            return View(userVM);
        }

        // GET: Admin/Users/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Admin/Users/Create
        
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("FirstName,LastName,Dob,ProfileImgURL,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUser appUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(appUser);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(appUser);
        //}

        // GET: Admin/Users/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var user = await _unitOfWork.AppUsers.GetAysnc(u => u.Id == id);
            if (user == null)
            {
                ViewBag.ErrorMassage = "Không tìm thấy người dùng này";
                return View("NotFound");
            }

           
            return View(appUser);
        }

        // POST: Admin/Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FirstName,LastName,Dob,ProfileImgURL,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUser appUser)
        {
            if (id != appUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppUserExists(appUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(appUser);
        }

        // GET: Admin/Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var appUser = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            return View(appUser);
        }

        // POST: Admin/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Users'  is null.");
            }
            var appUser = await _context.Users.FindAsync(id);
            if (appUser != null)
            {
                _context.Users.Remove(appUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppUserExists(int id)
        {
          return _context.Users.Any(e => e.Id == id);
        }
    }
}
