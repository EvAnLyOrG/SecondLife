using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SecondLife.Model;
using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;
using SecondLife.Services.Services;
using SecondLife.Services.Interfaces;
using SecondLife.Services.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondLifeAPI
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
            services.AddControllers();
            InjectServices(services);
            InjectRepositories(services);
            InjectValidators(services);
            services.AddDbContextPool<SalesDbContext>(x =>
            x.UseMySql(Configuration.GetConnectionString("SecondLifeConnection")));
        }

        private static void InjectRepositories(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IRepository<Annonce>, AnnonceRepository>();
            services.AddScoped<IRepository<User>, UserRepository>();
        }

        private static void InjectServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IService<>), typeof(GenericService<>));
            services.AddScoped<IService<Annonce>, AnnonceService>();
            services.AddScoped<IService<User>, UserService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAnnonceService, AnnonceService>();
        }

        private static void InjectValidators(IServiceCollection services)
        {
            services.AddScoped(typeof(IValidator<>), typeof(GenericValidator<>));
            services.AddScoped<IValidator<Annonce>, AnnonceValidator>();
            services.AddScoped<IValidator<User>, UserValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
