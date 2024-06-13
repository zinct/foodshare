using System;
namespace FoodShareAPI.Models
{
	public class Dashboard
	{
        public int TotalFoods { get; set; }
        public int TotalFoodGoodConditions { get; set; }
        public int TotalFoodNotGoods { get; set; }
        public int TotalFoodDistributeds { get; set; }
    }
}

