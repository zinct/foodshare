using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodShareAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}

