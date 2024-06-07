using Microsoft.AspNetCore.Mvc;
using FoodShareAPI.Models;
using FoodShareAPI.Exceptions;
using FoodShareAPI.Requests;
using Microsoft.AspNetCore.Identity;

namespace FoodShareAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public static List<Food> foodList = new List<Food>();

        public AuthController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            try
            {
                var user = _dbContext.Users.Where(user => user.Username == request.Username).First();

                if(user == null)
                {
                    throw new ApiErrorException(401, "Username atau password salah!");
                }

                bool verified = BCrypt.Net.BCrypt.Verify(request.Password, user.Password);

                if(!verified)
                {
                    throw new ApiErrorException(401, "Username atau password salah!");
                }

                return Ok(true);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

