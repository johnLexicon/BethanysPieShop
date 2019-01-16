using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShop
{
    public class Startup
    {
        //Contains the all the configuration info.
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //services instance is passed by using Dependency Injection.    
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //AddTransient means that a new instance of MockPieRepository will be created (By Dependency Injection) every time an instance is requested.
            services.AddTransient<IPieRepository, PieRepository>();

            services.AddMvc(); //The MVC Service must be added.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            /*** Middleware Components Configuration ***/

            /*** The sequence is important when adding the components below ***/

            //Makes sure that we get an exception if somthing goes wrong.
            //Only used in development mode.
            app.UseDeveloperExceptionPage();

            //Returns the status code page.
            app.UseStatusCodePages();

            //Will look after static files in the wwwroot folder and return them when needed.
            //Should be invoked before the UseMvcWithDefaultRoute for not bother the MVC route with static files like images and such that
            //should be handled by the static files middelware.
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
}
