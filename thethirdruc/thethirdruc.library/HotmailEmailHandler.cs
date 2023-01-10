namespace thethirdruc.library;

public class HotmailEmailHandler : IEmailHandler
{
    public void SendEmail(string to, string body, string? subject = null)
    {
            subject ??= "The lazy...";
        System.Console.WriteLine($"Sending hotmail '{body}' to: {to}. Subject: {subject}");
    }
}