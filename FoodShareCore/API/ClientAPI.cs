using FoodShareCore.Configuration;
using System.Net.Http.Json;

namespace FoodShareCore.API
{
    public class ClientAPI
    {
        private static ClientAPI instance;
        private static readonly object lockObject = new object();
        private HttpClient client = new HttpClient();
        private AppConfiguration appConfiguration;
        private string address;

        private ClientAPI()
        {
            appConfiguration = AppConfiguration.Instance;
            AppConfiguration.AppConfigurationData data = appConfiguration.ReadConfig();
            address = data.ApiUrl ?? "";
        }

        public static ClientAPI Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new ClientAPI();
                        }
                    }
                }
                return instance;
            }
        }

        public Task<HttpResponseMessage> Get(string path) => client.GetAsync(address + path);
        public Task<HttpResponseMessage> PostAsJson<T>(string path, T body) => client.PostAsJsonAsync<T>(address + path, body);
        public Task<HttpResponseMessage> PutAsJson<T>(string path, T body) => client.PutAsJsonAsync<T>(address + path, body);
        public Task<HttpResponseMessage> Delete(string path) => client.DeleteAsync(address + path);
    }
}
