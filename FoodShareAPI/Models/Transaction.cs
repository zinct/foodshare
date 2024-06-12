using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodShareAPI.Models
{
    public class Transaction
    {
        [JsonIgnore]
        public int Id { get; set; }

        public int FoodId { get; set; }

        public int Amount { get; set; }

        public int UserId { get; set; }

        [Column("created_at")]
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
    }
}

