using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using LessonMonitor.Core.Services;
using LessonMonitor.Core.Repositories;
using LessonMonitor.BL;
using LessonMonitor.DataAccess;
using LessonMonitor.Core;

namespace LessonMonitor.API
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
            services.AddScoped<IRepository<Lesson>, LessonsRepository>();

            services.AddScoped<ILessonsService, LessonsService>();

            services.AddTransient<IRepository<Member>, MembersRepository>();

            services.AddScoped<IMembersService, MembersService>();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LessonMonitor.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LessonMonitor.API v1"));
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseMiddleware<MyMiddlewareComponent>();

            //app.Use((httpContext, next) =>
            //{
            //    var task = next();

            //    return task;
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
