namespace thethirdruc.library;
public class GmailEmailHandler : IEmailHandler
{
    public void SendEmail(string to, string body, string? subject = null)
    {
        //do this do that
        subject ??= "The lazy...";
        System.Console.WriteLine($"Sending gmail '{body}' to: {to}. Subject: {subject}");
    }

}



