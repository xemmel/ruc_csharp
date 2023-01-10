namespace therucapi;

public class DummyGreetingHandler : IGreetingHandler
{
    private readonly IMessageHandler _messageHandler;

    public DummyGreetingHandler(IMessageHandler messageHandler)
    {
        _messageHandler = messageHandler;
    }
    public string GetGreeting()
    {
        return _messageHandler.GetTheMessage();
    }
}