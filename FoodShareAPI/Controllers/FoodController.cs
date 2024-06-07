using Microsoft.AspNetCore.Mvc;
using FoodShareAPI.Models;

namespace FoodShareAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public static List<Food> foodList = new List<Food>();

        public FoodController(ApplicationDBContext dbContext) 
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var foodList = _dbContext.Foods.ToList();
                return Ok(foodList);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Show(int id)
        {
            try
            {
                var food = _dbContext.Foods.Single(food => food.Id == id);
                return Ok(food);
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
        public ActionResult Store(Food foodRequest)
        {
            try
            {
                _dbContext.Foods.Add
                (
                    new Food
                    {
                        Name = foodRequest.Name,
                        Expire = foodRequest.Expire,
                        Conditions = foodRequest.Conditions,
                        Source = foodRequest.Source,
                        Category = foodRequest.Category,
                        Quantity = foodRequest.Quantity,
                    }
                );
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch(Exception e)
            {
                return StatusCode(500, e.InnerException.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var food = _dbContext.Foods.Single(food => food.Id == id);

                if (food == null)
                {
                    throw new ArgumentException();
                }

                _dbContext.Remove(food);
                _dbContext.SaveChanges();
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
        public ActionResult Update(int id, Food foodRequest)
        {
            try
            {
                var food = _dbContext.Foods.Single(food => food.Id == id);

                if(food == null)
                {
                    throw new ArgumentException();
                }

                food.Name = foodRequest.Name;
                food.Expire = foodRequest.Expire;
                food.Source = foodRequest.Source;
                food.Category = foodRequest.Category;
                food.Quantity = foodRequest.Quantity;

                _dbContext.SaveChanges();
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

