using BurgerShop.Application.Services.Abstract;
using BurgerShop.Application.Services.AppUserServices;
using BurgerShop.Application.Services.Concrete;
using BurgerShop.Application.Services.MenuServices;
using BurgerShop.Application.Services.OrderServices;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Repositories;
using BurgerShop.Infrastructure.Context;
using BurgerShop.Infrastructure.Repositories;
using BurgerShop.Infrastructure.SeedData;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSession();


builder.Services.AddControllersWithViews();



builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TolgaSQL")));
builder.Services.AddTransient<IBaseRepository<Address>, AddressRepository>()
                .AddTransient<IBaseRepository<AppUser>, AppUserRepository>()
                .AddTransient<IBaseRepository<Extra>, ExtraRepository>()
                .AddTransient<IBaseRepository<Menu>, MenuRepository>()
                .AddTransient<IBaseRepository<Order>, OrderRepository>()
                .AddTransient<IBaseService<Address>, AddressManager>()
                .AddTransient<IBaseService<AppUser>, AppUserManager>()
                .AddTransient<IBaseService<Extra>, ExtraManager>()
                .AddTransient<IBaseService<Menu>, MenuManager>()
                .AddTransient<IBaseService<Order>, OrderManager>()
                .AddTransient<IMenuService, MenuService>()
                .AddTransient<IOrderService, OrderService>();








builder.Services.AddIdentity<AppUser, IdentityRole<Guid>>(options =>
{
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequiredLength = 3;
    options.Password.RequireNonAlphanumeric = false;

}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

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

app.UseSession();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


SeedDataGenerator.Seed(app, 100, 2, 5, 3, 3);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
