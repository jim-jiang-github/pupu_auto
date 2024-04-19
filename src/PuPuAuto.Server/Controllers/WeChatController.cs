using Microsoft.AspNetCore.Mvc;
using PuPuAuto.Contracts;

namespace PuPuAuto.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeChatController : ControllerBase
    {
        private readonly ILogger<WeChatController> _logger;
        private readonly IWeChatService _weChatService;

        public WeChatController(ILogger<WeChatController> logger, IWeChatService weChatService)
        {
            _logger = logger;
            _weChatService = weChatService;
        }

        [HttpGet(Name = "SendMessage")]
        public async Task<bool> SendMessage(string user, string message)
        {
            return await _weChatService.SendMessage(user, message);
        }
    }
}
