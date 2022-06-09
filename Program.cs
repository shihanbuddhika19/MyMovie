

using InventoryBeginners.Data;
using Microsoft.EntityFrameworkCore;
using InventoryBeginners.Repositories;
using InventoryBeginners.Interfaces;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.


builder.Services.AddDbContext<InventoryContext>(options =>
{
    
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConn"));
});


//builder.Services.AddDbContext<InventoryContext>(options =>
//    options.UseSqlServer("DbConn")); ;

builder.Services.AddScoped<iMovie,MovieRepository>();
// Add services to the container.
builder.Services.AddControllersWithViews();

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
