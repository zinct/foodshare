using Microsoft.AspNetCore.Mvc;
using FoodShareAPI.Models;
using FoodShareAPI.Requests;
using FoodShareAPI.Exceptions;

namespace FoodShareAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public DashboardController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var totalGoodFood = _dbContext.Foods.Where(food => food.Status == "good").Count();
                var totalBadFood = _dbContext.Foods.Where(food => food.Status == "bad").Count();
                var totalFood = _dbContext.Foods.Count();
                var totalDistributed = _dbContext.Transactions.Sum(transaction => transaction.Amount);

                return Ok(
                    new Dashboard() 
                        { 
                            TotalFoodDistributeds = totalDistributed,
                            TotalFoodGoodConditions = totalGoodFood,
                            TotalFoodNotGoods = totalBadFood,
                            TotalFoods = totalFood,
                        } 
                    );
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

