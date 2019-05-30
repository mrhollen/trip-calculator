using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace TripCalculator
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors()
                .AddMvc()
                .AddJsonOptions(options => {
                    // Send back a ISO date
                    var settings = options.SerializerSettings;
                    settings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;

                    // Don't mess with case of properties
                    var resolver = options.SerializerSettings.ContractResolver as DefaultContractResolver;
                    resolver.NamingStrategy = null;
                });

            services.AddCors(options => 
                    options.AddPolicy("AllowAll", 
                        p => p.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()));

            services.AddTransient<TripService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            })
            .UseCors("AllowAll");
        }
    }
}
