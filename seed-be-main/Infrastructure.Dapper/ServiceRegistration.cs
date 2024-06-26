using Infrastructure.Dapper.DapperServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Dapper
{
    public static class ServiceRegistration
    {
        public static void AddDapperInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Repositories
            services.AddTransient<IDapper, Dapperr>();
            #endregion
        }
    }
}
