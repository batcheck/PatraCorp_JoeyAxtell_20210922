using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PatraCorp_JoeyAxtell_20210922
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello Patra Corp! \n");
                    await context.Response.WriteAsync("My Name is Joey Axtell and I'm applying for the Devops Position. \n");
                    await context.Response.WriteAsync("This is a simple webpage deployed with Github Actions with the infrastructure created in Azure using Terraform Azure provider. \n");
                    await context.Response.WriteAsync("Thank you for considering me for the Devops roles within your company. \n");
                });
            });
        }
    }
}
