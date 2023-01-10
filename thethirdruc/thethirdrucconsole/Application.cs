namespace thethirdrucconsole;

public class Application
{
    private readonly IProcessHandler _processHandler;
    private readonly IRUCLogger _logger;

    public Application(IProcessHandler processHandler, IRUCLogger logger)
    {
        _processHandler = processHandler;
        _logger = logger;
    }
    public void Run(string[] args)
    {
        _logger.Log("Beginning");
        _processHandler.DoEverything();
    }
}

