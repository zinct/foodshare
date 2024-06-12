using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FoodShareAPI.Requests
{
	public class CreateFoodRequest
	{
        public DateOnly Expire { get; set; }
        public string Name { get; set; }
        public string Conditions { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    }
}

