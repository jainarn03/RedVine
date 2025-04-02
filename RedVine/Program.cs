using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RedVine.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("RedVineContextConnection") ?? throw new InvalidOperationException("Connection string 'RedVineContextConnection' not found.");

builder.Services.AddDbContext<RedVineContext>(options => options.UseSqlite(connectionString));

builder.Services.AddDefaultIdentity<RedVineUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<RedVineContext>();

// Add services to the container.
builder.Services.AddControllersWithViews(); // Enable MVC
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Set default route to HomeController
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.MapRazorPages(); // Keep this for Razor Pages if needed

app.Run();
