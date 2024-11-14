using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            // Uygulamadaki servisler buraya eklenecek

            services.AddControllersWithViews();


        }

        

        //middleware buraya yazılır. request ve response arasında müdahale etmemizi saĞLAYAN ARA KATMANLAR 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            // Bu bir midllewaredir
            app.UseRouting();


            // Bu bir midllewaredir
            app.UseEndpoints(endpoints =>
            {
                /*
                 endpoints.MapGet("/test", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                 */
                
                endpoints.MapDefaultControllerRoute(); //   {controller = Home}/{action/index}/{id?} 
            });
        }
    }
}
