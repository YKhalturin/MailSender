using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace MailSender.lib
{
    public class MailSenderService
    {
        public string ServerAddress { get; set; }
        public int ServerPort { get; set; }
        public bool UseSSL { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public MailSenderService() { }

        public struct Email
        {
            public string SenderAddress, RecipientAddress, Subject, Body;

            Email(string senderAddress, string recipientAddress, string subject, string body)
            {
                SenderAddress = senderAddress;
                RecipientAddress = recipientAddress;
                Subject = subject;
                Body = body;
            }
        }

        private SmtpClient SetSmtp()
        {
            SmtpClient smtpClient = new SmtpClient(ServerAddress, ServerPort);
            smtpClient.EnableSsl = UseSSL;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential
            {
                UserName = Login,
                Password = Password
            };
            return smtpClient;
        }

        public void SendMessage(Email email)
        {
            MailMessage mailMessage = new MailMessage(email.SenderAddress, email.RecipientAddress);
            mailMessage.Subject = email.Subject;
            mailMessage.Body = email.Body;
            mailMessage.IsBodyHtml = false;
            SmtpClient smtpClient = SetSmtp();
            using (smtpClient)
            {
                try
                { 
                    smtpClient.Send(mailMessage);
                }
                catch (SmtpException e)
                {
                    Trace.TraceError(e.ToString());
                    throw;
                }
               
            }
        }
    }
}