using DataModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;

namespace ExtResourcesBlazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var cs = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<PartnersContext>(options => options.UseSqlServer(cs));

            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddScoped<IPartnerRepository, PartnerRepository>();
            services.AddScoped<IResourceRepository, ResourceRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IResourceLevelRepository, ResourceLevelRepository>();
			services.AddSyncfusionBlazor();
            services.AddServerSideBlazor().AddHubOptions(c => { c.MaximumReceiveMessageSize = 102400000; });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDMzODA3QDMxMzkyZTMxMmUzMFUxR3FZRnJiaTdOUkhyRm03QVIrV3hwb2h5UjlCVTJ2UC9sc2p2YWxPU0E9");
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
