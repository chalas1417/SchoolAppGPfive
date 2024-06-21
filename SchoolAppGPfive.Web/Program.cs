using Microsoft.EntityFrameworkCore;
using SchoolAppGPfive.DAL.Context;
using SchoolAppGPfive.DAL.Daos;
using SchoolAppGPfive.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Registrar el context//
builder.Services.AddDbContext<SchoolContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("connectionString")));

builder.Services.AddScoped<IDepartamentDb, DepartamentDb>();
builder.Services.AddScoped<ICourseDb, CourseDb>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Course}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Departament}/{action=Index}/{id?}");

app.Run();
