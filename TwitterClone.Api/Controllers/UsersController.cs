using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new[]
            {
                new
                {
                    Id = 1,
                    Username = "niloy@45",
                    Name = "Niloy Acharjee"
                },
                new
                {
                    Id = 2,
                    Username = "rahim@56",
                    Name = "Rahim"
                },
                new
                {
                    Id = 3,
                    Username = "karim@25",
                    Name = "Karim"
                }
            };

            return Ok(users);
        }
    }
}