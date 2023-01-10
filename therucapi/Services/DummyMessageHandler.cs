namespace therucapi;

public class DummyMessageHandler : IMessageHandler
{
    public string GetTheMessage()
    {
        return "A message!!!";
    }
}