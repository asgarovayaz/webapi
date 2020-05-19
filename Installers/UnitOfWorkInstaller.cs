using WebApiSkeleton.Core;
using WebApiSkeleton.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApiSkeleton.Installers
{
    public class UnitOfWorkInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
