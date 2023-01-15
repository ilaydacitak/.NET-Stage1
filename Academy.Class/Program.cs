using System;

namespace Academy.Class
{
    class Program
    {
        static void Main(string[] args)
        {


            YahooService yahooService = new YahooService();
            GmailService gmailService = new GmailService();

            EmailService emailService = new EmailService();

            /*//1.KULLANIM
            UserService userService = new UserService();
            userService.firstName = "Gizem";
            userService.lastName = "Yılmaz";
            userService.Email = "gizem@gmail.com";

            //2.KULLANIM
            UserService userService2 = new UserService()
            {
                Email = "gizem@gmail.com",
                firstName = "Gizem", // set bloğu gibi ***
                lastName = "yılmaz"
            };

            //BİRTAKIM BAŞKA İŞLER YAPILDIKTAN SONRA DEĞERİ DE GİREBİLİRİZ
            //Email = "gizem@gmail.com", GİBİ



            var name = userService2.firstName; // get bloğu gibi ***
            */

            UserService userService = new UserService();
            gmailService.SendMail();
            yahooService.SendMail();


            emailService.SendMail(new YahooService());



            
        }
    }
}
