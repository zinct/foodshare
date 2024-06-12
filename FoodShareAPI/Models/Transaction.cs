using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodShareAPI.Models
{
    public class Transaction
    {
        [JsonIgnore]
        public int Id { get; set; }
        [Column("food_id")]
        public int FoodId { get; set; }

        public int Amount { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("created_at")]
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
    }
}

