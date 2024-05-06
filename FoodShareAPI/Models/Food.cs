using System;
namespace FoodShareAPI.Models
{
    public class Food
    {
        public DateTime CreatedAt { get; set; }
        public DateOnly Expire { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Condition { get; set; }
        public String Source { get; set; }
        public String Category { get; set; }
        public int Quantity { get; set; }

        public Food(DateOnly expire, String name, String description, String condition, String source, String category, int quantity)
        {
            Expire = expire;
            Name = name;
            Description = description;
            Condition = condition;
            Source = source;
            Category = category;
            Quantity = quantity;

            CreatedAt = DateTime.Now;
        }
    }
}

