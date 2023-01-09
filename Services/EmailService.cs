using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace IE307.N11.Services
{
    public class EmailService
    {
        private static readonly String gmail = "vuthimy247396@gmail.com";
        private static readonly String displayName = "AnkiDroid";
        private static readonly String password = "umscjscmzmjugyub";
        private static readonly String host = "smtp.gmail.com";
        public EmailService()
        {

        }

        public static void SendEmail(string htmlString, string subject, string recipient)
        {
            SendEmail(htmlString, subject, new List<string> {recipient});
        }

        public static void SendEmail(string htmlString, string subject, List<string> recipients)
        {
            var smtpClient = new SmtpClient(host)
            {
                Port = 587,
                Credentials = new NetworkCredential(gmail, password),
                EnableSsl = true,
            };
            var mailMessage = new MailMessage
            {
                From = new MailAddress(gmail, displayName),
                Subject = subject,
                Body = htmlString,
                IsBodyHtml = true,
            };

            foreach (String recipient in recipients)
            {
                mailMessage.To.Add(recipient);
            }

            smtpClient.Send(mailMessage);
        }

        public static void SendEmailTest()
        {
            var smtpClient = new SmtpClient(host)
            {
                Port = 587,
                Credentials = new NetworkCredential(gmail, password),
                EnableSsl = true,
            };
            var mailMessage = new MailMessage
            {
                From = new MailAddress(gmail),
                Subject = "Test",
                Body = "<h1>Hello</h1>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add("dakto1019@gmail.com");

            smtpClient.Send(mailMessage);

            try
            {
                /*
                var smtpClient = new SmtpClient(host)
                {
                    Port = 587,
                    Credentials = new NetworkCredential(gmail, password),
                    EnableSsl = true,
                };
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(gmail),
                    Subject = "Test",
                    Body = "<h1>Hello</h1>",
                    IsBodyHtml = true,
                };
                mailMessage.To.Add("dakto1019@gmail.com");

                smtpClient.Send(mailMessage);
                */
            }
            catch (Exception)
            {

            }

            /*
            try
            {

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("vuthimy247396@gmail.com", "Test mail");
                message.To.Add(new MailAddress("dakto1019@gmail.com"));
                message.Subject = "Test";
                message.IsBodyHtml = false; //to make message body as html
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("vuthimy247396@gmail.com", "vuthi52138");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
            */
        }
    }
}
