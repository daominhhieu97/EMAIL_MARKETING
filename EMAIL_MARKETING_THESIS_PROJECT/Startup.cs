using EMAIL_MARKETING_THESIS_PROJECT.Controllers;
using EMAIL_MARKETING_THESIS_PROJECT.DAL;
using EMAIL_MARKETING_THESIS_PROJECT.Infrastructure;
using EMAIL_MARKETING_THESIS_PROJECT.Models.CustomerAnalyzers;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EMAIL_MARKETING_THESIS_PROJECT
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
            services.AddControllersWithViews();
            services.AddMvc();
            RegisterDependencies(services);
            services.AddDbContext<ProjectContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ProjectConnection")));
            RegisterOAuthWithFacebook(services);
            RegisterEasyQuery(services);
        }

        private void RegisterEasyQuery(IServiceCollection services)
        {
        }

        private void RegisterOAuthWithFacebook(IServiceCollection services)
        {
            services.AddAuthentication(options =>
                    {
                        options.DefaultChallengeScheme = FacebookDefaults.AuthenticationScheme;
                        options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                        options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    })
                .AddFacebook(options =>
                {
                    options.AppId = "2451937834934499";
                    options.AppSecret = "7460c2ddf9374184ea33e2d32568145e";
                })
                .AddCookie()
                ;
        }

        private void RegisterDependencies(IServiceCollection services)
        {
            services.AddSingleton(new DemographicFiltering());
            services.AddSingleton(new GeographicFiltering());
            services.AddScoped(typeof(EmailSender));
            services.AddScoped(typeof(SubscriberParser));
            services.AddScoped<IKmeanCustomerAnalyzer, RFMKMeanAnalyzer>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
     {
         endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
     });
        }
    }
}