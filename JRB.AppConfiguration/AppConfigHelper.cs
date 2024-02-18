using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace JRB.AppConfiguration
{
    public static class AppConfigHelper
    {

        public static T GetJsonConfig<T>(string fileName, bool optional = true, bool reloadOnChange = true) where T : new()
        {
            IConfiguration configuration = GetConfiguration(fileName, optional, reloadOnChange);

            T result = new T();
            configuration.Bind(result);
            return result;
        }

        public static T GetJsonConfig<T>(string fileName, string sectionName, bool optional = true, bool reloadOnChange = true) where T : new()
        {
            IConfiguration configuration = GetConfiguration(fileName, optional, reloadOnChange);

            T result = new T();
            configuration.GetSection(sectionName).Bind(result);
            return result;
        }

        private static IConfiguration GetConfiguration(string fileName, bool optional = true, bool reloadOnChange = true)
        {
            return new ConfigurationBuilder()
                .AddJsonFile(fileName, optional, reloadOnChange)
                .Build();
        }

    }
}