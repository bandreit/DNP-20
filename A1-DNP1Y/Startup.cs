using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using A1_DNP1Y.Data;
using A1_DNP1Y.Data.Impl;
using A1_DNP1Y.Persistence;
using Syncfusion.Blazor;

namespace A1_DNP1Y
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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<FileContext>();
            services.AddSingleton<IFamilyService, FamilyService>();
            services.AddSyncfusionBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(
                "MzMwMzgwQDMxMzgyZTMzMmUzMGlWSFo2S3NHQ21hNGl6V3Q3c2JDU3ZEWkREcXV2UWNOU0EvM1FscitwK3M9;MzMwMzgxQDMxMzgyZTMzMmUzMGxLajBPOStJTUc4SE1HRHNuN0RmbFhMS3ljY3BxSnNaaUZRSkxBMUFWMlk9;MzMwMzgyQDMxMzgyZTMzMmUzMFpJVFZldllQQ2cybVRjS3JGV1NmbGlBdDJxaitzT2NzTWZCUDU5UXFyd2s9;MzMwMzgzQDMxMzgyZTMzMmUzMElWVU1VMndWWTNTM2V6SzZsOHIzNDVsbVRtN2RDNEl5OHNKUWVFaFBXeG89;MzMwMzg0QDMxMzgyZTMzMmUzMFllbVJiM2FMRENkamRCU0dHR3NrMzVhVHJ2M09POUQzdWppS0UyTVFZdUk9");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();    
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}