using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyJob.API.Applicants.Domain.Repositories;
using EasyJob.API.Applicants.Domain.Services;
using EasyJob.API.Applicants.Persistence.Repository;
using EasyJob.API.Applicants.Services;
using EasyJob.API.Payments.Domain.Repositories;
using EasyJob.API.Payments.Domain.Services;
using EasyJob.API.Payments.Domain.Services.Communication;
using EasyJob.API.Payments.Persistence.Repository;
using EasyJob.API.Payments.Services;
using Go2Climb.API.Domain.Repositories;
using Go2Climb.API.Persistence.Contexts;
using Go2Climb.API.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace EasyJob.API
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "EasyJob.API", Version = "v1"});
                c.EnableAnnotations();
            });
            
            //Configure en InMemory Database
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseInMemoryDatabase("easy-job-api");
            });
            
            // Configure SQL: services.AddDbContext<AppDbContext>();
            
            //Dependency rules
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IApplicantService, ApplicantService>();
            services.AddScoped<IApplicantRepository, ApplicantRepository>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();

            
            //AutoMapper Dependency Injection 
            //services.AddAutoMapper(typeof(Startup));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EasyJob.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}