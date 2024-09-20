using Company.Repository.Interfaces;
using Company.Repository.Repositories;
using Company.Service.Interfaces;
using Company.Service.Interfaces.Services;
using Company.Service.Mapping;
using Data.Models.Contexts;
using Data.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Company.Web;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<CompanyDbContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
        // builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<IdepartmentService, DepartmentService>();
        builder.Services.AddScoped<IEmployeeService, EmployeeService>();
        builder.Services.AddAutoMapper(x => x.AddProfile<EmployeeProfile>());
        builder.Services.AddAutoMapper(x => x.AddProfile<DepartmentProfile>());
        
        builder.Services.AddIdentity<ApplicationUser, IdentityRole>(config =>
        {
            config.Password.RequiredUniqueChars = 2;
            config.Password.RequireDigit = true;
            config.Password.RequireLowercase = true;
            config.Password.RequireUppercase = true;
            config.Password.RequireNonAlphanumeric = true;
            config.Password.RequiredLength = 6;
            config.User.RequireUniqueEmail = true;
            config.Lockout.AllowedForNewUsers = true;
            config.Lockout.MaxFailedAccessAttempts = 3;
            config.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromHours(1);
        }).AddEntityFrameworkStores<CompanyDbContext>().AddDefaultTokenProviders();

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.Cookie.HttpOnly = true;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
            options.SlidingExpiration = true;
            options.LoginPath = "/Account/Login";
            options.LogoutPath = "/Account/Logout";
            options.AccessDeniedPath = "/Account/AccessDenied";
            options.Cookie.Name = "OmarCookies";
            options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            options.Cookie.SameSite = SameSiteMode.Strict;
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
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        
        app.UseAuthorization();
        
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Account}/{action=SignUp}");

        app.Run();
    }
}