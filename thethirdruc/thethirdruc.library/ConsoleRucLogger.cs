namespace thethirdruc.library;

public class ConsoleRucLogger : IRUCLogger
{
    private readonly IEmailHandler _emailHandler;

    public ConsoleRucLogger(IEmailHandler emailHandler)
    {
        _emailHandler = emailHandler;
    }
    public void Log(string text)
    {
        _emailHandler.SendEmail("logger","I'm logging","ff");
        System.Console.WriteLine(text);
    }
}