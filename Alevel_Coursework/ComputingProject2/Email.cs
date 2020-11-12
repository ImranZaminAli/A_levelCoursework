using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace ComputingProject2
{
    class Email
    {

        public Email(string to, string subject, string message)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("project.alevel@gmail.com", "abc123"); // not the acutal password. just here for demonstration purposes
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mailMessage = new MailMessage("project.alevel@gmail.com", to, subject, message);
            smtpClient.Send(mailMessage);
        }
    }
}
