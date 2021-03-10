using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuestionaryProject.AutoMapperConfigurations;
using QuestionaryProject.Data.Data;
using QuestionaryProject.Data.Data.Repository;
using QuestionaryProject.Data.IRepository.Questions;

namespace QuestionaryProject
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
            services.AddTransient<IQuestionsRepository, QuestionsRepository>();

            services.AddControllers();
            services.AddRazorPages();

            services.AddDbContext<QuestionaryContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConn")));

            services.AddSingleton<IMapper>(s => AutoMapperFactory.CreateMapper());
            services.AddSwaggerGen();

            services.AddMvc( options => options.EnableEndpointRouting = false);
            services.AddCors();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            //app.UseSwagger();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors(c => { c.AllowAnyOrigin().AllowAnyMethod().AllowAnyMethod(); });

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Real Time Messaging V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseMvcWithDefaultRoute();


            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("Complaints","{controller}/{action}/{id?}");
            //});
        }
    }
}
