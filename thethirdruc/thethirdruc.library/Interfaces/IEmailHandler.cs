namespace thethirdruc.library;

public interface IEmailHandler
{
    void SendEmail(string to, string body, string? subject = null);
}