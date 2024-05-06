using System.Text.Json;

namespace FoodShareCore.Configuration
{
    public class AppConfiguration
    {
        public class AppConfigurationData
        {
            public string? ApiUrl;
            public string? AppName;
            public string? AppVersion;
        }

        public AppConfigurationData ReadConfig()
        {
            string path = Directory.GetCurrentDirectory();
            string configFileName = "FoodShare.runtimeconfig.json";

            string json = File.ReadAllText($"{path}../../../../../FoodShareCore/{configFileName}");
            AppConfigurationData appConfiguration = JsonSerializer.Deserialize<AppConfigurationData>(json, new JsonSerializerOptions { IncludeFields = true });

            return appConfiguration;
        }
    }
}
