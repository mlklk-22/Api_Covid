 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using covidvaccineAPI.CORE.Common;
using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using covidvaccineAPI.INFRA.Common;
using covidvaccineAPI.INFRA.Repository;
using covidvaccineAPI.INFRA.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

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
            services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("policy",
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            services.AddAuthentication(opt => {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>{
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"))
        };
    });








            services.AddControllers();
            services.AddScoped<IDbContext, DbContext>();
            services.AddScoped<IVaccinesRepository, VaccinesRepository>();
            services.AddScoped<IUserAccountRepository, UserAccountRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();   
            services.AddScoped<ITestmonialRepository, TestmonialRepository>();
            services.AddScoped<IVaccinationCenterRepository ,VaccinationCenterRepository>();
            services.AddScoped<IJWTRepository, JWTRepository>();
            services.AddScoped<IHomeRepository, HomeRepository>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IUserReservationRepository, UserReservationRepository>();
            services.AddScoped<ICertificateVaccineRepository, CertificateVaccineRepository>();
            services.AddScoped<IUserInfoRepository, UserInfoRepository>();
            services.AddScoped<IFooterRepository, FooterRepository>();

            /////////////hello////////
            services.AddScoped<IUserAccountService, UserAccountService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<ITestmonialService, TestmonialService>();
            services.AddScoped<IVaccinationCenterService, VaccinationCenterService>();
            services.AddScoped<IJWTService, JWTService>();
            services.AddScoped<IGenericService<Vaccines>, VaccinesService>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IUserReservationService, UserReservationService>();
            services.AddScoped<ICertificateVaccineService, CertificateVaccineService>();
            services.AddScoped<IUserInfoService, UserInfoService>();
            services.AddScoped<IFooterService, FooterService>();



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

            app.UseCors("policy");

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
