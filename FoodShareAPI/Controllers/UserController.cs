using Microsoft.AspNetCore.Mvc;
using FoodShareAPI.Models;

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

        [HttpPost]
        public IActionResult Store(User userRequest)
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
    }
}

