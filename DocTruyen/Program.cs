using DocTruyen.DataAccess.Data;
using DocTruyen.Service.Helpers;
using DocTruyen.Service.IRepository;
using DocTruyen.Service.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(typeof(MapperInitilizer).Assembly);

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

app.UseAuthorization();
app.MapControllerRoute(
    name: "Admin",
    pattern: "{area=Admin}/{controller=Categories}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "area",
    pattern: "{area:exists}/{controller=AdminHome}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=AdminHome}/{action=Index}/{id?}");

app.Run();
