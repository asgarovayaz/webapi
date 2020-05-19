using WebApiSkeleton.Core.Repositories;
using WebApiSkeleton.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApiSkeleton.Installers
{
    public class UserRepositoryInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
        }
    }
}
