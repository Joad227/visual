using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            MailAddress fromMailAddress = new MailAddress("sasharomanuk199929@gmail.com", "Саша Романюк");
            MailAddress toAddress = new MailAddress("sasharomanuk1999@gmail.com", "Саша Романюк");

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "типа тема";
                mailMessage.Body = "блабла";

                smtpClient.Host = "sasharomanuk199929@gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "q1w2e3r4zqxwcevr");

                smtpClient.Send(mailMessage);
            }
        }
    }
}
