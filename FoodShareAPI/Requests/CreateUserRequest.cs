using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodShareAPI.Requests
{
    public class CreateUserRequest
    {
        public string Name { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
