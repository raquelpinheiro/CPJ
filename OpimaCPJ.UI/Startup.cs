using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpimaCPJ.Web.Data;
using OpimaCPJ.Domain.Interfaces;
using OpimaCpj.Data.Context;
using Opima.CPJ.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Opima.CPJ.Application.Interfaces;
using OpimaCPJ.Domain.Interfaces.Repository;
using OpimaCpj.Data.Repository;
using OpimaCPJ.Domain;
using Opima.CPJ.Application.AutoMapper;
using AutoMapper;

namespace OpimaCPJ.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            /*
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            */
            
            services.AddAutoMapper();
           
            var connString = Configuration.GetConnectionString("LocalConnection");

            /*
            services.AddEntityFrameworkSqlServer().
                    AddDbContext<OpimaCpjContext>(options => 
                            options.UseSqlServer(connString, b => b.MigrationsAssembly("OpimaCPJ.Web"));
                    }, ServiceLifetime.Scoped );
             */
           
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<OpimaCpjContext>(options =>
                {
                    options.UseSqlServer(connString,
                                        sqlOptions => sqlOptions.MigrationsAssembly("OpimaCPJ.Web"));
                },
                ServiceLifetime.Scoped // Note that Scoped is the default choice
                                        // in AddDbContext. It is shown here only for
                                        // pedagogic purposes.
                );
            
            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(connString, b => b.MigrationsAssembly("OpimaCPJ.Web")));                    
            
            // registro de injecao de dependência
            services.AddScoped<IPessoaFisicaAppService, PessoaAppService>();
            //services.AddScoped<IRepositoryPessoaFisica, RepositoryPessoaFisica>();
            
            services.AddDefaultIdentity<IdentityUser>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();
        
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
