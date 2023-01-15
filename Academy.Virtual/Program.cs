using Academy.Virtual;

class VirtualClass
{
    static void Main(string[] args)
    {
        GmailService gmailService = new GmailService();

        gmailService.SendMail();

        Console.ReadLine();
    }
}