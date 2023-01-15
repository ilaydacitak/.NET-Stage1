using Academy.Virtual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Virtual
{
    public class MailService
    {
        public virtual void SendMail()
        {
            Console.WriteLine("first send mail");
        }
    }
}

public class GmailService : MailService
{
    public override void SendMail()
    {
        Console.WriteLine("second send mail");

        //bir takım işler

        base.SendMail();
    }
}
