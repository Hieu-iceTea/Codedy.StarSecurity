using Codedy.StarSecurity.WebApp.Models.Catalog.Careers;
using Codedy.StarSecurity.WebApp.Models.Catalog.Clients;
using Codedy.StarSecurity.WebApp.Models.Catalog.Services;
using Codedy.StarSecurity.WebApp.Models.Catalog.Users;
using Codedy.StarSecurity.WebApp.Models.Database.EF;
using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Codedy.StarSecurity.WebApp
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
            services.AddDbContext<StarSecurityDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("StarSecurityDbConnect")));

            services.AddTransient<ICareersService,CareersService>();
            services.AddTransient<IUsersService,UsersService>();
            services.AddTransient<IClientsService,ClientsService>();
            services.AddTransient<IServicesService,ServicesService>();

            services.AddIdentity<User, Role>().AddEntityFrameworkStores<StarSecurityDbContext>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute(
                    name: "MyAreaAccount",
                    areaName: "Account",
                    pattern: "Account/{controller=Account}/{action=Login}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
