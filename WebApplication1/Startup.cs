using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication1
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }

        public class mojDbContextFactory : IDesignTimeDbContextFactory<mojDbContext>
        {
            public mojDbContext CreateDbContext(string[] args)
            {
                
                var optionsBuilder = new DbContextOptionsBuilder<mojDbContext>();
                optionsBuilder.UseSqlServer(@"Server=tcp:p1903restoran.database.windows.net,1433;Initial Catalog=restoran; Persist Security Info=False;User ID=testniUser;Password=testTest123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

                return new mojDbContext(optionsBuilder.Options);
            }
        }


        public class mojDbContextFactory : IDesignTimeDbContextFactory<mojDbContext>
        {
            public mojDbContext CreateDbContext(string[] args)
            {

                var optionsBuilder = new DbContextOptionsBuilder<mojDbContext>();
                optionsBuilder.UseSqlServer(@"Server=.;Database=restoranTemp;Trusted_Connection=true;MultipleActiveResultSets=true;User ID=sa;Password=test;");

                return new mojDbContext(optionsBuilder.Options);
            }
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<mojDbContext>(options=> options.UseSqlServer(Configuration.GetConnectionString("IB150198T")));
            services.AddControllersWithViews();

            services.AddMvc();
            services.AddDistributedMemoryCache();
            services.AddSession();
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
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
