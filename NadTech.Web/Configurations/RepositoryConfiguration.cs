using Microsoft.Extensions.DependencyInjection;
using NadTech.Core;
using NadTech.Core.Repositories;
using NadTech.Persistence;
using NadTech.Persistence.Repositories;

namespace NadTech.Web.Configurations
{
    public static class RepositoryConfiguration
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

        }
    }
}
