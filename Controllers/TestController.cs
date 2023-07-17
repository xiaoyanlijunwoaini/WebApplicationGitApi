using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationGitApi.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = "get")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = "dfeeeeeedfdf"//Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
