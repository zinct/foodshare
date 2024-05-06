using Microsoft.AspNetCore.Mvc;
using FoodShareAPI.Models;
using FoodShareCore.Utilities;

namespace FoodShareAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
                return StatusCode(500, e.Message);
            }
        }


        [HttpGet("{id}")]
        public ActionResult<Food> Show(int id)
        {
            try
            {
                return ListUtilities.ReadByID<Food>(foodList, id);
            }
            catch (Exception e)
            {
                // Catch ArgumentOutOfRangeException exception
                if (e is ArgumentOutOfRangeException)
                {
                    return NotFound();
                }

                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public ActionResult Store(Food food)
        {
            try
            {
                foodList = ListUtilities.Create<Food>(foodList, food);
                return NoContent();
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                ListUtilities.Delete<Food>(foodList, id);
                return NoContent();
            }
            catch (Exception e)
            {
                // Catch ArgumentOutOfRangeException exception
                if (e is ArgumentOutOfRangeException)
                {
                    return NotFound();
                }

                return StatusCode(500, e.Message);
            }
            
        }

        [HttpPut("{id}")]
        public ActionResult<Food> Update(int id, Food data)
        {
            try
            {
                foodList = ListUtilities.Update<Food>(foodList, data, id);
                return NoContent();
            }
            catch (Exception e)
            {
                // Catch ArgumentOutOfRangeException exception
                if (e is ArgumentOutOfRangeException)
                {
                    return NotFound();
                }

                return StatusCode(500, e.Message);
            }
        }
    }
}

