
namespace thethirdruc.library;

public class MyProcessHandler : IProcessHandler
{
    private readonly IEmailHandler _emailHandler;
    private readonly IRUCLogger _logger;

    public MyProcessHandler(IEmailHandler emailHandler, IRUCLogger logger)
    {
        _emailHandler = emailHandler;
        _logger = logger;
    }
    public void DoEverything()
    {
        _logger.Log("I'm starting");
        _emailHandler.SendEmail("dd","ff","ddd");
        _logger.Log("I'm ending");
    }

    
}