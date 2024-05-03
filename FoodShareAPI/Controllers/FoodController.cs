using Microsoft.AspNetCore.Mvc;
using FoodShareAPI.Models;

namespace FoodShareAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {
        public static List<Food> foodList = new List<Food>();

        [HttpGet]
        public ActionResult<IEnumerable<Food>> Get()
        {
            try
            {
                return foodList;
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }


        [HttpGet("{id}")]
        public ActionResult<Food> Show(int id)
        {
            try
            {
                return foodList[id];
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public ActionResult Store(Food food)
        {
            foodList.Add(food);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                foodList.RemoveAt(id);
                return NoContent();
            }
            catch (Exception e)
            {
                
                return StatusCode(500);
            }
            
        }
    }
}

