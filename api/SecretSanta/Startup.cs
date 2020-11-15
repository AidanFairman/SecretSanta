using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecretSanta.Mappers;
using SecretSanta.Services.Games;
using SecretSanta.Services.Members;
using SecretSanta.Services.Profiles;
using SecretSanta.Services.Wishes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SecretSanta
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
            services.AddSingleton<IServiceProvider>(sp => sp);
            System.Reflection.Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(item => !item.IsAbstract && !item.IsInterface)
            .ToList()
            .ForEach(assignedTypes =>
            {
                if (assignedTypes.GetInterfaces().Length > 0)
                {
                    assignedTypes.GetInterfaces().ToList().ForEach(type => services.AddSingleton(type, assignedTypes));
                }
                else
                {
                    services.AddScoped(assignedTypes);
                }
            });

            services.AddControllers();
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
