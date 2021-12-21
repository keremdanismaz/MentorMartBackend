using MentorCity.API.Helpers;
using MentorCity.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace MentorCity.API
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
            services.AddDbContext<PostgreSqlDbContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly("MentorCity.Entities")));

            services.AddScoped<DbContext>(provider => provider.GetService<PostgreSqlDbContext>());
            services.AddScoped<JwtService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MentorCity.API", Version = "v1" });
            });

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
        .AddCookie(options =>
        {
            options.AccessDeniedPath = "/accessdenied"; // Must be lowercase
            options.LoginPath = "/account/google-login";
        })
      .AddGoogle(options =>
      {
          options.ClientId = "31232930414-s4elaa84d5rnu7rp479b4p6ds5b4vn12.apps.googleusercontent.com";
          options.ClientSecret = "Or51wZCtNsbQRkE8uyPEFCUj";
          options.SaveTokens = true;
      });

            services.AddCors();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(options =>
            options.WithOrigins("http://localhost:3000", "https://accounts.google.com", "https://localhost:44385/")
            .AllowAnyHeader()
            .AllowAnyMethod());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MentorCity.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseCors();

            app.UseAuthentication();
            //app.UseMvc();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}