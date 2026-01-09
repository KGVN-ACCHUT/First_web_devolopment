using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using First_web_devolepment.Data;

var builder = WebApplication.CreateBuilder(args);

// Tell the app to use MVC (Webpages)
builder.Services.AddControllersWithViews();

// Tell the app to use our Database "Librarian"
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add the "Cookie Security" lock for Phase 1
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => {
        options.LoginPath = "/Account/Login";
    });

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

// Turn on the Security "Authentication" and "Authorization"
app.UseAuthentication();
app.UseAuthorization();

// This line tells the app to open the Todo page by default
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TodoTasks}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TodoTasks}/{action=Index}/{id?}");
app.Run();
