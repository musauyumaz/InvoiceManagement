using InvoiceManagement.Persistence.Configurations;
using InvoiceManagement.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InvoiceManagement.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            new Configuration(configuration);
            services.AddDbContext<InvoiceManagementDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
