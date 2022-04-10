using BusinessLayer.BL;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Models;
using UnitOfWorkUOW;

namespace projektTAIIB
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
            services.AddDbContext<Database>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IArmia, BLArmia>();
            services.AddScoped<IBron, BLBron>();
            services.AddScoped<IDywizja, BLDywizja>();
            services.AddScoped<IModel, BLModel>();
            services.AddScoped<IStopien, BLStopien>();
            services.AddScoped<IZgloszenie, BLZgloszenie>();
            services.AddScoped<IZolnierz, BLZolnierz>();
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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
