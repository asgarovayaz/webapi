using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSkeleton.Core.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApiSkeleton.Installers
{
    public class ConfigurationsInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var applicationOptions = new ApplicationOptions();
            
            var dbConnectionOptions = new DbConnectionOptions();
            
            var mailOptions = new MailOptions();
            
            var resourceFolderOptions = new ResourceFolderOptions();

            var swaggerOptions = new SwaggerOptions();

            configuration.Bind(nameof(applicationOptions), applicationOptions);

            configuration.Bind(nameof(dbConnectionOptions),dbConnectionOptions);
            
            configuration.Bind(nameof(mailOptions), mailOptions);
            
            configuration.Bind(nameof(resourceFolderOptions), resourceFolderOptions);
            
            configuration.Bind(nameof(swaggerOptions), swaggerOptions);

            services.AddSingleton(applicationOptions);

            services.AddSingleton(dbConnectionOptions);
            
            services.AddSingleton(mailOptions);
            
            services.AddSingleton(resourceFolderOptions);
            
            services.AddSingleton(swaggerOptions);

        }
    }
}
