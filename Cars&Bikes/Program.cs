using Cars_Bikes.Data;
using Cars_Bikes.Models;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TwoWheelerDB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Con")));
builder.Services.AddDbContext<FourWheelerDB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Con")));

builder.Services.AddSession();
builder.Services.AddAuthentication("MyCookieAuth")
    .AddCookie("MyCookieAuth", options =>
    {
        options.LoginPath = "/Account/Login"; // Redirect here if not logged in
        options.LogoutPath = "/Account/Logout";
        options.AccessDeniedPath = "/Account/AccessDenied";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30); // Cookie expires in 30 min
        options.SlidingExpiration = true; // Renew cookie on activity
        options.Cookie.HttpOnly = true; // Prevent JavaScript access (more secure)
        options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Use only HTTPS
        options.Cookie.SameSite = SameSiteMode.Strict; // Prevent cross-site acces
    });
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
    options.AddPolicy("AuthorOnly", policy => policy.RequireRole("Author"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
//app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    ContentTypeProvider = new FileExtensionContentTypeProvider
    {
        Mappings = { [".avif"] = "image/avif" }
    }
});
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseSession(); // Enable session

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "twoWheelerDetails",
        pattern: "{brandName}/{twName}",
        defaults: new { controller = "Home", action = "TwoWheelerDetails" });

    endpoints.MapDefaultControllerRoute(); // Other default routes
});
