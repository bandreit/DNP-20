using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ToDoWAuth.Authentication;
using ToDoWAuth.Data;
using ToDoWAuth.Data.Impl;

namespace ToDoWAuth
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
            services.AddSingleton<ITodosService, TodoService>();
            services.AddScoped<IUserService, InMemoryUserService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("CanCreateNewTodoForEveryone", a => a.RequireAuthenticatedUser().RequireAssertion(
                    context =>
                    {
                        Claim levelClaim = context.User.FindFirst(claim => claim.Type.Equals("Level"));
                        if (levelClaim == null) return false;
                        return int.Parse(levelClaim.Value) >= 2;
                    }));
                options.AddPolicy("PrivateToDoCreator",
                    a => a.RequireAuthenticatedUser().RequireClaim("Role", "PrivateToDoer"));
                options.AddPolicy("CanCreateTodo", a => a.RequireAuthenticatedUser().RequireAssertion(
                    context =>
                    {
                        Claim levelClaim = context.User.FindFirst(claim => claim.Type.Equals("Level"));
                        if (levelClaim == null) return false;
                        Claim levelClaim2 = context.User.FindFirst(claim => claim.Type.Equals("Role"));
                        if (levelClaim2 == null) return false;
                        return int.Parse(levelClaim.Value) >= 1 || levelClaim2.ToString() == "Dumbie";
                    }));
                options.AddPolicy("CanViewAllToDos", a => a.RequireAuthenticatedUser().RequireAssertion(
                    context =>
                    {
                        Claim levelClaim = context.User.FindFirst(claim => claim.Type.Equals("Level"));
                        if (levelClaim == null) return false;
                        return int.Parse(levelClaim.Value) >= 1;
                    }));
                options.AddPolicy("PrivateToDoer", a => a.RequireAuthenticatedUser().RequireClaim("Role", "PrivateUser"));
                options.AddPolicy("CanDeleteTodo", a => a.RequireAuthenticatedUser().RequireClaim("Role", "Admin"));
            });
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