using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Class
{
    public class EmailService
    {
        public void SendMail(IMailService mailModel)
        {
            mailModel.SendMail();
        }

        public void SendMails(IMailService mailModel)
        {
            mailModel.SendMails();
        }


    }
}
