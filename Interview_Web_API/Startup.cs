using FluentAssertions.Common;
using Interview_Web_API.Database;
using Interview_Web_API.Models;
using Interview_Web_API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace Interview_Web_API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            // DbContext için bağlantı dizesini ekledim
            var connectionString = _configuration.GetConnectionString("Interview_Web_API_Connection");

            // DbContext'i ekledim
            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(connectionString));


            // Dependency Injection
            services.AddScoped<ProjectsService>();
            services.AddScoped<UsersService>();


            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

         
    }
}

    

