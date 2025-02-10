using Cars_Bikes.Data;
using Cars_Bikes.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TwoWheelerDB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Con")));
builder.Services.AddDbContext<FourWheelerDB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Con")));

builder.Services.AddSession(); // Add session service

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
