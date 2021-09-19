using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Account;
using Ecommerce.Core.Model.SettingEmail;
using EcommerceBackEnd.Models;
using EcommerceBackEnd.Reposiotrys;
using EcommerceBackEnd.Resources;
using EcommerceBackEnd.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Globalization;
using System.Reflection;
using Ecommerce.Core.Model.RoleManager;
using EcommerceBackEnd.UserClaimsPrincipalFactory;
using Serilog;
using EcommerceBackEnd.PathFiles;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace EcommerceBackEnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("EcommerceContext"), b => b.MigrationsAssembly("EcommerceBackEnd")));

            services.AddTransient<IAccount, AccountRepository>();
            services.AddSingleton<DataProtectionPurposeString>();
            services.AddTransient<ICompany, CompanyRepository>();
            services.AddTransient<IRole, RoleRepository>();
            services.AddTransient<IUom, UomRepository>();
            services.AddTransient<ICategory, CategoryRepository>();
            services.AddTransient<ISubCategory, SubCategoryRepository>();
            services.AddTransient<IModel, ModelRepository>();
            services.AddTransient<IProduct, ProductRepository>();
            services.AddTransient<IMenuItem, MenuItemRepository>();
            services.AddTransient<IMenu, MenuRepository>();
            services.AddTransient<IMainMenu, MainMenuRepository>();
            services.AddTransient<ILookup, LookupRepository>();
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);

                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Home/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddIdentity<Account, Role>(a =>
            {
                a.Password.RequiredLength = 6;
                a.Password.RequireLowercase = true;
                a.Password.RequireUppercase = true;
                a.User.AllowedUserNameCharacters = null;
                a.Password.RequireNonAlphanumeric = false;
                a.Password.RequiredUniqueChars = 1;
                a.Lockout.AllowedForNewUsers = true;
                a.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
                a.Lockout.MaxFailedAccessAttempts = 5;
                a.User.AllowedUserNameCharacters =
               "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
               
                a.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<DataContext>()
            .AddDefaultTokenProviders()
            .AddClaimsPrincipalFactory<ModifyUserClaimsPrincipalFactory>()
            .AddSignInManager();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddSingleton<LocalizationService>();
            services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                    {
                        var assemblyName = new AssemblyName(typeof(ApplicationResource).GetTypeInfo().Assembly.FullName);
                        return factory.Create("ApplicationResource", assemblyName.Name);
                    };
                });

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en"),
                    new CultureInfo("km"),
                };
                options.DefaultRequestCulture = new RequestCulture("en");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddHttpContextAccessor();
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            services.AddSingleton<IEmailSender, EmailSender>();

            services.Configure<DataProtectionTokenProviderOptions>(opt =>
               opt.TokenLifespan = TimeSpan.FromDays(1));

            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            services.Configure<PathConfiguation>(Configuration.GetSection(nameof(PathConfiguation)));
            services.AddSingleton<IPathConfiguation>(sp => sp.GetRequiredService<IOptions<PathConfiguation>>().Value);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                Path.Combine(Configuration["PathConfiguation:ProductPath"])),
                RequestPath = "/product_images"
            });
            app.UseSerilogRequestLogging();
            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=login}/{id?}");
            });
        }
    }
}
