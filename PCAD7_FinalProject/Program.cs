using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PCAD7_Project_MVC.Models;
using PCAD7_Project_MVC.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Step 4
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProduct, ProductDBCRUDRepository>(); //register of services for db.
builder.Services.AddScoped<IFileUploadService, FileUploadService>();
builder.Services.AddDbContext<ProductContext>(options => options.UseSqlServer("Server=DESKTOP-92827RR;Database=PCAD7Product;Trusted_Connection=true;MultipleActiveResultSets=True"));
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Lockout.MaxFailedAccessAttempts = 10;
    options.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<UserContext>();

builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer("Server=DESKTOP-92827RR;Database=PCAD7Users;Trusted_Connection=true;MultipleActiveResultSets=True"));
//builder.Services.AddDbContext<ProductContext>(options => options.UseSqlite("Data Source=Product.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) //can find the environment in Properties Foulder in launchSettins.json
{
    app.UseExceptionHandler("/Home/Error");
}
if(app.Environment.IsStaging())
{
    app.UseExceptionHandler("Home/StagingError");
}
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ProductContext>();
    dbContext.Database.EnsureCreated(); //creates db  id if not there
    var userdbContext = scope.ServiceProvider.GetRequiredService<UserContext>();
    userdbContext.Database.EnsureCreated(); // create db if not there
}
 //app.Services.GetService<ProductContext>().Database.EnsureCreated();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{name?}");

app.Run();

