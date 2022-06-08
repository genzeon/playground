using ContactManagerProject.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication("MyCookieAuth").AddCookie("MyCookieAuth", options =>
{ 
     options.Cookie.Name = "MyCookieAuth";
     options.LoginPath = "/Logins/Index";
    //options.AccessDeniedPath
});
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("MustBelongToAdimn", policy => policy.RequireClaim("Adimn"));
    options.AddPolicy("MustBelongToUser", policy => policy.RequireClaim("User"));
});
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Data>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("ContactManager")));

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
