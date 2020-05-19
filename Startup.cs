using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoWrapper;
using WebApiSkeleton.Core.Helpers;
using WebApiSkeleton.Core.Options;
using WebApiSkeleton.Installers;

namespace WebApiSkeleton
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        readonly string AllowedOrigins = "_allowedOrigins";

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => {
                options.AddPolicy(AllowedOrigins, builder =>
                {
                    builder.WithOrigins(Configuration["ApplicationInformation:Address"]);
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
                    builder.AllowCredentials();
                });
            });

            services.InstallServicesFromAssembly(Configuration);
            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                var swaggerOptions = new SwaggerOptions();
                Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);

                app.UseSwagger(option => { option.RouteTemplate = swaggerOptions.JsonRoute; });
                app.UseSwaggerUI(option => { option.SwaggerEndpoint(swaggerOptions.UIEndpoint, swaggerOptions.Descrtiption); });
            }


            //app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseCors(AllowedOrigins);

            app.UseApiResponseAndExceptionWrapper<AutoWrapperProfile>();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
