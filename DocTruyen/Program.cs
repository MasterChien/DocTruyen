using DocTruyen.DataAccess.Data;
using DocTruyen.DataAccess.Models;
using DocTruyen.Service.Helpers;
using DocTruyen.Service.IRepository;
using DocTruyen.Service.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var cloudinarySettings = builder.Configuration.GetSection("CloudinarySettings");
builder.Services.Configure<CloudinarySettings>(cloudinarySettings);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddAutoMapper(typeof(MapperInitilizer).Assembly);

builder.Services.TryAddScoped<ISystemClock, SystemClock>();

builder.Services.AddIdentityCore<AppUser>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireUppercase = false;
})
.AddRoles<AppRole>()
.AddRoleManager<RoleManager<AppRole>>()
.AddUserManager<UserManager<AppUser>>()
.AddSignInManager<SignInManager<AppUser>>()
.AddRoleValidator<RoleValidator<AppRole>>()
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
    options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
.AddIdentityCookies();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areaRoute",
        pattern: "{area:exists}/{controller}/{action}");
    endpoints.MapAreaControllerRoute(
        name: "User",
        areaName: "User",
        pattern: "{area=User}/{controller=Home}/{action=Index}/{id?}");
    endpoints.MapAreaControllerRoute(
       name: "Admin",
       areaName: "Admin",
       pattern: "{area=Admin}/{controller=AdminHome}/{action=Index}/{id?}");
    //endpoints.MapAreaControllerRoute(
    //  name: "Identity",
    //  areaName: "Identity",
    //  pattern: "{area=Identity}/{controller=Accounts}/{action=Login}/{ReturnUrl?}");
});
app.Run();
