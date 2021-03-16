using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NadTech.Data;

namespace NadTech.Web.Configurations
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NadTechCustomerDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("dbContext")));

            services.AddRepositories();

            

            return services;
        }
    }
}
