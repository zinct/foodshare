using System.Net.Http.Json;

namespace FoodShareCore.API
{
    public class ClientAPI
    {
        private HttpClient client = new HttpClient();
        private String address;

        public ClientAPI()
        {
            address = "http://localhost:5276/api";
        }

        public Task<HttpResponseMessage> Get(String path) => client.GetAsync(address + path);

        public Task<HttpResponseMessage> PostAsJson<T>(String path, T body) => client.PostAsJsonAsync<T>(address + path, body);

        public Task<HttpResponseMessage> PutAsJson<T>(String path, T body) => client.PutAsJsonAsync<T>(address + path, body);

        public Task<HttpResponseMessage> Delete(String path) => client.DeleteAsync(address + path);
    }
}
