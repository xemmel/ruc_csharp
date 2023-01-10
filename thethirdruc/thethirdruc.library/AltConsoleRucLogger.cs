namespace thethirdruc.library;

public class AltConsoleRucLogger : IRUCLogger
{
    private readonly IEmailHandler _emailHandler;

    public AltConsoleRucLogger(IEmailHandler emailHandler)
    {
        _emailHandler = emailHandler;
    }
    public void Log(string text)
    {
        _emailHandler.SendEmail("logger","I'm logging","ff");
        System.Console.WriteLine($"Alt: {text}");
    }
}