using Microsoft.AspNetCore.Mvc;
using FoodShareAPI.Models;
using FoodShareAPI.Requests;
using FoodShareAPI.Exceptions;

namespace FoodShareAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public FoodController(ApplicationDBContext dbContext) 
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Food> foodList = _dbContext.Foods
                        .ToList();
                
                return Ok(foodList);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("good-condition")]
        public IActionResult GetGoodConditionFood()
        {
            try
            {
                List<Food> foodList = _dbContext.Foods
                    .Where(food => food.Status == "Good")
                        .ToList();

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
        public ActionResult Store(CreateFoodRequest foodRequest)
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
        public ActionResult Update(int id, CreateFoodRequest foodRequest)
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

        [HttpPost("change-status/{id}")]
        public ActionResult ChangeStatus(int id, String status)
        {
            try
            {
                var food = _dbContext.Foods.Single(food => food.Id == id);

                if (food == null)
                {
                    throw new ArgumentException();
                }

                food.Status = status;

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

        [HttpPost("distributed/{id}")]
        public ActionResult Distributed(int id, DistributedRequest request)
        {
            try
            {
                var food = _dbContext.Foods.Single(food => food.Id == id);

                if (food == null)
                {
                    throw new ArgumentException();
                }

                if(food.Quantity < request.Amount)
                {
                    throw new ApiErrorException(400, "Stok makanan tidak mencukupi");
                }

                _dbContext.Transactions.Add(new Transaction()
                {
                    FoodId = food.Id,
                    UserId = id,
                });
                food.Quantity = food.Quantity - request.Amount;


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

                if (e is ApiErrorException)
                {
                    return StatusCode(((ApiErrorException)e).ErrorCode, ((ApiErrorException)e).Message);
                }

                return StatusCode(500, e.Message);
            }
        }
    }
}

