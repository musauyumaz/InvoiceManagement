using InvoiceManagement.Application.Abstractions.Repositories.Blocks;
using InvoiceManagement.Application.Abstractions.Repositories.Homes;
using InvoiceManagement.Persistence.Configurations;
using InvoiceManagement.Persistence.Contexts;
using InvoiceManagement.Persistence.Repositories.Blocks;
using InvoiceManagement.Persistence.Repositories.Homes;
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
            services.AddDbContext<InvoiceManagementDbContext>(options =>
            {
                options.UseSqlServer(Configuration.ConnectionString);
                //options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            services.AddScoped<IHomeCommandRepository, HomeCommandRepository>();
            services.AddScoped<IHomeQueryRepository, HomeQueryRepository>();
            services.AddScoped<IBlockCommandRepository, BlockCommandRepository>();
            services.AddScoped<IBlockQueryRepository, BlockQueryRepository>();

        }
    }
}
