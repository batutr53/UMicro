using Microsoft.AspNetCore.Authentication.Cookies;
using UMicro.Web.Handler;
using UMicro.Web.Models;
using UMicro.Web.Services;
using UMicro.Web.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ResourceOwnerPasswordTokenHandler>();
builder.Services.AddHttpClient<IIdentityService, IdentityService>();

var serviceapiSettings = configuration.GetSection("ServiceApiSettings").Get<ServiceApiSettings>();
builder.Services.AddHttpClient<IUserService, UserService>(opt =>
{
    opt.BaseAddress = new Uri(serviceapiSettings.IdentityBaseUri);
}).AddHttpMessageHandler<ResourceOwnerPasswordTokenHandler>();
builder.Services.Configure<ClientSettings>(configuration.GetSection("ClientSettings"));
builder.Services.Configure<ServiceApiSettings>(configuration.GetSection("ServiceApiSettings"));
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie
    (CookieAuthenticationDefaults.AuthenticationScheme, opts => {
        opts.LoginPath = "/Auth/SignIn";
        opts.ExpireTimeSpan = TimeSpan.FromDays(60);
        opts.SlidingExpiration = true;
        opts.Cookie.Name = "udemywebcookie";
    });
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
