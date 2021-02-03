using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Neoldu.Data.Domain.Entities;
using NeOldu.Data.Dal;
using NeOldu.Data.Dal.Abstract;
using NeOldu.Data.Dal.Concrete;
using NeOldu.Data.Dal.Concrete.Manager;
using NeOldu.Data.Dal.Core;
using System;

namespace NeOldu.Client
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:50000").AllowAnyHeader().AllowAnyMethod();
                    });
            });
            var neOlduDbContext = Configuration.GetConnectionString("NeOlduDbContext");
            services.AddDbContext<NeOlduDbContext>(opt => opt.UseSqlServer(neOlduDbContext));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddControllersWithViews();
            services.AddScoped<IApplicaitonBlockDal, ApplicaitonBlockDal>();
            services.AddScoped<IApplicaitonReactionDal, ApplicaitonReactionDal>();
            services.AddScoped<IApplicationTypeDal, ApplicationTypeDal>();
            services.AddScoped<IApplicationUserDal, ApplicationUserDal>();
            services.AddScoped<IApplicationUserCommentDal, ApplicationUserCommentDal>();
            services.AddScoped<IPeopleDal, PeopleDal>();
            services.AddScoped<IDeathDateDal, DeathDateDal>();
            services.AddScoped<IFileManager, FileManager>();
            services.AddScoped<IMapperService, AutoMapperManager>();
            services.AddAuthentication("CookieAuth")
                .AddCookie("CookieAuth", x =>
                {
                    x.Cookie.Name = "Grandmas.Cookie";
                    x.LoginPath = "/Oturum/GirisYap";
                });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, NeOlduDbContext db)
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

            bool itCreated = db.Database.EnsureCreated();
            if (itCreated)
            {
                var applicationTypeAdmin = new ApplicationType { Id = Guid.NewGuid(), Type = "Admin" };
                var applicationTypeUser = new ApplicationType { Id = Guid.NewGuid(), Type = "User" };
                db.ApplicationTypes.Add(applicationTypeAdmin);
                db.ApplicationTypes.Add(applicationTypeUser);
                db.ApplicationUsers.Add(new ApplicationUser()
                {
                    Id = Guid.NewGuid(),
                    Email = "admin@gmail.com",
                    Password = "123",
                    UserName = "Zulfu",
                    FirstName = "Zulfu",
                    LastName = "Sevgi",
                    ApplicationType = applicationTypeAdmin,
                    ApplicationTypeId = applicationTypeAdmin.Id,
                });
                db.SaveChanges();
            }
            app.UseRouting();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Oturum}/{action=GirisYap}/{id?}");
            });
        }
    }
}
