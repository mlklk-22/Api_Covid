using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using covidvaccineAPI.CORE.Common;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using covidvaccineAPI.INFRA.Common;
using covidvaccineAPI.INFRA.Repository;
using covidvaccineAPI.INFRA.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace covidvaccine.API
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
            services.AddScoped<IDbContext, DbContext>();

            services.AddScoped<IUserAccountRepository, UserAccountRepository>();
             services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<ITestmonialRepository, TestmonialRepository>();
            
            services.AddScoped<IUserAccountService, UserAccountService>();
             services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<ITestmonialService, TestmonialService>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
