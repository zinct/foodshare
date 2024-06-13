using System.Text.Json;

namespace FoodShareCore.Configuration
{
    public class AppConfiguration
    {
        private static AppConfiguration instance;
        private static readonly object lockObject = new object();
        private AppConfigurationData configData;

        public class AppConfigurationData
        {
            public string? ApiUrl;
            public string? AppName;
            public string? AppVersion;
        }

        private AppConfiguration()
        {
            configData = ReadConfig();
        }

        public static AppConfiguration Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new AppConfiguration();
                        }
                    }
                }
                return instance;
            }
        }

        public AppConfigurationData GetConfigData()
        {
            return configData;
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
