using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodShareAPI.Models
{
    public class User
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        [Column("created_at")]
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
    }
}

