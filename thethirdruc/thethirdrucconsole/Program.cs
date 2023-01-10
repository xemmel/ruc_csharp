namespace thethirdrucconsole;
class Main2
{
    static void Main(string[] args)
    {
        // :-( -> ENTER DI!!
       // var app = new Application(new GmailEmailHandler());
       //var app = new Application(new MyProcessHandler(new GmailEmailHandler()));

       var app = DIFactory.GetService<Application>();
       app.Run(args);
    }
}
