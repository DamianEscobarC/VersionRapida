using Microsoft.EntityFrameworkCore;
using TechFixPro.Data;

var builder = WebApplication.CreateBuilder(args);

var cs = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
    opt.UseMySql(cs, ServerVersion.AutoDetect(cs)));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ordenes}/{action=Index}/{id?}");

app.Run();