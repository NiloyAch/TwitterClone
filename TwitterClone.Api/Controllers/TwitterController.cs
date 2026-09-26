using Microsoft.AspNetCore.Mvc;

using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitterController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public TwitterController(IConfiguration configuration)
           
        {
            _configuration = configuration;
        }


        [HttpGet("tweets")]
        public IActionResult GetTweets()
        {
            var maxTweetLength = _configuration.GetValue<int>("TwitterSettings:MaxTweetLength");

            var response = new
            {
                maxLength = maxTweetLength,
                tweets = new[]
                {
                    new {Id = 1, Text = "Web API Development with ASP.NET Core"},
                    new {Id = 2, Text = "Exploring Web API"}
                    
                }

                
            };

            return Ok(response);
        }

        [HttpGet("app-info")]
        public IActionResult GetAppInfo()
        {
            var appName = _configuration.GetValue<string>("AppName");
            var apiKey = _configuration.GetValue<string>("ApiKey");

            return Ok(new 
            {
                AppName =  appName,
                Apikey = apiKey
            }
            
            );
        }
    }
}
