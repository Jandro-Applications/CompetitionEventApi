using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompetitionEventApi.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CompetitionEventApi.Services;
using CompetitionEventApi.Services.Interfaces;
using CompetitionEventApi.Services.Services;
using CompetitionEventApi.Models;
using CompetitionEventApi.Services.DataObjects;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CompetitionEventApi
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<CompetitionApiDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IContestantService, ContestantService>();
            services.AddScoped<ICompetitionEventService, CompetitionEventService>();
            services.AddScoped<ICompetitionScoreService, CompetitionScoreService>();
            services.AddScoped<ICompetitionService, CompetitionService>();
            services.AddScoped<IPostService, PostService>();

            services.AddCors(o => o.AddPolicy("ApiPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CompetitionViewModel, Competition>();
                cfg.CreateMap<PostViewModel, Post>();
                cfg.CreateMap<RelatedEventCompetition, RelatedEventCompetitionViewModel>();
                cfg.CreateMap<CompetitionEvent, CompetitionEventViewModel>()
                    .ForMember(x => x.RelatedCompetitionIds, opt => opt.Ignore());

                cfg.CreateMap<CompetitionEventViewModel, CompetitionEvent>();

                cfg.CreateMap<CompetitionApplicationViewModel, CompetitionApplication>();
                cfg.CreateMap<CompetitionScoreViewModel, CompetitionScore>();
                cfg.CreateMap<CompetitionViewModel, Competition>();
                cfg.CreateMap<ContestantViewModel, Contestant>();
            });

            IMapper mapper = config.CreateMapper();

            services.AddSingleton(mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Amk/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseCors("ApiPolicy");

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Amk}/{action=Index}/{id?}");
            });
        }
    }
}
