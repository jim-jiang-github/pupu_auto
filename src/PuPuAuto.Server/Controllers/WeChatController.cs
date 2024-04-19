using Microsoft.AspNetCore.Mvc;
using PuPuAuto.Contracts;

namespace PuPuAuto.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeChatController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeChatController> _logger;
        private readonly IWeChatService _weChatService;

        public WeChatController(ILogger<WeChatController> logger, IWeChatService weChatService)
        {
            _logger = logger;
            _weChatService = weChatService;
        }

        [HttpGet(Name = "GetWeChat")]
        public IEnumerable<WeatherForecast> GetWeChat()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
