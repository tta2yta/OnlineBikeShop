using Microsoft.EntityFrameworkCore;
using OnlineBikeShop.AppDbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//add dbcontext
builder.Services.AddDbContext<BikeDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    "ByYearMonth",
//    "make/bikes/{month}/{years}",
//    new {controller="Make", action="bikes" }
//    );
//app.MapControllerRoute(
//    "ByYearMonth",
//    "make/bikes/{month:int}/{years:int}",
//    new { controller = "Make", action = "bikes" }
//    );
//app.MapControllerRoute(
//    "ByYearMonth",
//    "make/bikes/{month:int:lenght(4)}/{years:int:range(1,10)}",
//    new { controller = "Make", action = "bikes" }
//    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
