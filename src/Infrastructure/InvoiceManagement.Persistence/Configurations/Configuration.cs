using Microsoft.Extensions.Configuration;

namespace InvoiceManagement.Persistence.Configurations
{
    public class Configuration
    {
        private static IConfiguration _configuration;

        public Configuration(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public static string? ConnectionString => _configuration.GetConnectionString("MsSQL");
    }
}
