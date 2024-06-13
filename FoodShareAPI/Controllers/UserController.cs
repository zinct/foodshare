using Microsoft.AspNetCore.Mvc;
using FoodShareAPI.Models;
using FoodShareAPI.Requests;

namespace FoodShareAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public UserController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var users = _dbContext.Users.ToList();

                return Ok(users);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.InnerException.Message);
            }
        }

        [HttpPost]
        public IActionResult Store(CreateUserRequest userRequest)
        {
            try
            {
                _dbContext.Users.Add
                (
                    new User
                    {
                        Name = userRequest.Name,
                        Username = userRequest.Username,
                        Password = BCrypt.Net.BCrypt.HashPassword(userRequest.Password),
                    }
                );
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.InnerException.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CreateUserRequest request)
        {
            try
            {
                var user = _dbContext.Users.Single(user => user.Id == id);

                if (user == null)
                {
                    throw new ArgumentException();
                }

                user.Name = request.Name;
                user.Username = request.Username;

                if(!string.IsNullOrEmpty(request.Password))
                {
                    user.Password = BCrypt.Net.BCrypt.HashPassword(request.Password);
                }

                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.InnerException.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var user = _dbContext.Users.Single(user => user.Id == id);

                if (user == null)
                {
                    throw new ArgumentException();
                }

                _dbContext.Remove(user);
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

                return StatusCode(500, e.InnerException.Message);
            }
        }
    }
}

