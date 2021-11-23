using Microsoft.Extensions.Configuration;

namespace DotNetFramework.Core
{
    static class Configuration
    {
        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            return config;
        }

        public static string BrowserName => InitConfiguration().GetSection("Configuration").GetSection("browser").Value;
        public static string BaseUrl => InitConfiguration().GetSection("Configuration").GetSection("baseUrl").Value;
    }
}
