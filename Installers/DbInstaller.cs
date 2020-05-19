using WebApiSkeleton.Core.Options;
using Microsoft.Extensions.Configuration;
using WebApiSkeleton.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApiSkeleton.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            switch (configuration["DBConnection:Provider"])
            {
                case "MSSQL": 
                    services.AddDbContext<WebApiSkeletonContext>(option => option.UseSqlServer(configuration["DBConnection:ConnectionString"]));
                    break;
                    
            }

        }
    }
}
