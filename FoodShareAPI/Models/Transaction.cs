using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodShareAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [Column("food_id")]
        public int FoodId { get; set; }

        public Food Food { get; set; }

        public int Amount { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }

        public User User { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}

