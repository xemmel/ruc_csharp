using Microsoft.AspNetCore.Mvc;

namespace therucapi.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    private readonly ILogger<GreetingController> _logger;
    private readonly IGreetingHandler _greetingHandler;

    public GreetingController(
            ILogger<GreetingController> logger,
            IGreetingHandler greetingHandler)
    {
        _logger = logger;
        _greetingHandler = greetingHandler;
    }

    [HttpGet(Name = "GetGreeting")]
    public string Get()
    {
        return _greetingHandler.GetGreeting();
    }
}
