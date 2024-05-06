using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace FoodShareRuntimeConfig
{
    public class Configuration()
    {
        public string ApiURL { get; set; }
        public string Status { get; set; }
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public int maxTitleLength { get; set; }
        public int descTitleLength { get; set; }
    }

    public Configuration() { }

    public Config(string ApiURL, string Status, string AppName, string AppVersion, int maxTitleLength, int descTitleLength)
    {
        ApiURL = APIUrl;
        Status = status;
        AppName = name;
        AppVersion = version;
        maxTitleLength = maxTitle;
        descTitleLength = descTitle;
    }

    public class FoodShareConfig
    {
        public Configuration config { get; set; }
        public string path = Directory.GetCurrentDirectory();
        public string configFileName = "FoodShare.runtimeconfig.json";

        public FoodShareConfig()
        {
            try
            {
                ReadConfig();
            }
            catch
            {
                SetDefault();
                WriteConfig();
            }
        }

        // Method untuk membaca file configurasi
        private Configuration ReadConfig()
        {
            string jsonFromFile = File.ReadAllText(path + '/' + configFileName);
            config = JsonSerializer.Deserialize<Config>(jsonFromFile);
            return config;
        }

        // Method untuk menulis file configurasi
        private void WriteConfig()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String jsonString = JsonSerializer.Serialize(config, options);
            string fullPath = path + '/' + configFileName;
            File.WriteAllText(fullPath, jsonString);
        }

        // Deklarasi nilai Default-nya dari FoodShareConfig
        public void SetDefault()
        {
            config = new Configuration("\"http://localhost:5276/api\"", "Development", "Food Share", "0.1", 50, 200);
        }
    }

}
