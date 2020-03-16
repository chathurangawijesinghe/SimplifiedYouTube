using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Capgemini.SimplifiedYouTube.Contexts.Videos;
using Capgemini.SimplifiedYouTube.Core.Application.Videos.Videos.Queries.GetAll;
using Capgemini.SimplifiedYouTube.gRPCService.Videos.Services;
using Capgemini.SimplifiedYouTube.Repositories.IVideos;
using Capgemini.SimplifiedYouTube.Repositories.Videos;
using Capgemini.SimplifiedYouTube.Services.IVideos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;
using Capgemini.SimplifiedYouTube.Common.Mappers.Videos;
using Microsoft.Extensions.Configuration;

namespace Capgemini.SimplifiedYouTube.gRPCService.Videos
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
            services.AddGrpc();

            services.AddDbContext<VideoContext>
              (options => options.UseSqlServer(Configuration.GetConnectionString("VideoDatabaseConnection")));

            services.AddTransient<DbContext, VideoContext>();
            services.AddTransient<IVideoRepository, VideoRepository>();
            //services.AddTransient<IUnitOfWork, UnitOfWork>();

            //services.AddTransient<ITestMapper, TestMapper>();

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new VideoProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddTransient<IVideoService, SimplifiedYouTube.Services.Videos.VideoService>();
            //services.AddTransient<ICommonFacade, CommonFacade>();

            services.AddMediatR(typeof(GetAllQuery).GetTypeInfo().Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<VideoService>();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });
        }
    }
}
