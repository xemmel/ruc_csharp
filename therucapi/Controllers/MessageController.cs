using Microsoft.AspNetCore.Mvc;

namespace therucapi.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly ILogger<MessageController> _logger;
    private readonly IMessageHandler _messageHandler;

    public MessageController(
            ILogger<MessageController> logger,
            IMessageHandler messageHandler)
    {
        _logger = logger;
        _messageHandler = messageHandler;

         
    }

    [HttpGet(Name = "GetMessage")]
    public string Get()
    {
        return _messageHandler.GetTheMessage();
    }
}
