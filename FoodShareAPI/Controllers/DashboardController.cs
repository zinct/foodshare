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
                return Ok(new Dashboard() { TotalFoodDistributeds = 2, TotalFoodGoodConditions = 3, TotalFoodNotGoods = 5, TotalFoods = 5 } );
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

