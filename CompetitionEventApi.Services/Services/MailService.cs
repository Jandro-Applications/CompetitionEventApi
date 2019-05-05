using CompetitionEventApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionEventApi.Services.Services
{
    public class MailService : IMailService
    {
        public void SendMail(string message,string to)
        {
            MailMessage mail = new MailMessage("amkbilogora@amkbilogora.hr", to);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("amkbilogora@amkbilogora.hr", "amkbilogora!1");
            client.Host = "mail.amkbilogora.hr";
            mail.Subject = "Prijava na show";
            mail.Body = message;
            mail.CC.Add("amkbilogora@amkbilogora.hr");
            mail.IsBodyHtml = true;
            client.Send(mail);
        }
    }
}
