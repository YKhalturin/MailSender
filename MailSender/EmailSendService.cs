using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace WpfTestMailSender
{
    public class EmailSendService
    {
        NetworkCredential _credentials;
        Email _email;

        public EmailSendService(NetworkCredential credentials, Email email)
        {
            _credentials = credentials;
            _email = email;
        }

        public struct Email
        {
            public string From, To, Subject, Body;

            Email(string from, string to, string subject, string body)
            {
                From = from;
                To = to;
                Subject = subject;
                Body = body;
            }
        }

        private MailMessage SetEmailData()
        {
            MailMessage mailMessage = new MailMessage(_email.From, _email.To);
            mailMessage.Subject = _email.Subject;
            mailMessage.Body = _email.Body;
            mailMessage.IsBodyHtml = false;
            return mailMessage;
        }

        private SmtpClient SetSmtp()
        {
            SmtpClient smtpClient = new SmtpClient(MailSenderData.SmtpAdress, MailSenderData.SmtpPort);
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential
            {
                UserName = _credentials.UserName,
                Password = _credentials.Password
            };
            return smtpClient;
        }

        public void SendMessage()
        {
            MailMessage mailMessage = SetEmailData();
            SmtpClient smtpClient = SetSmtp();
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show($"Письмо отправлено по адресу: {mailMessage.To}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно отправить письмо. Причина: " + ex.Message);
            }
        }
    }
}