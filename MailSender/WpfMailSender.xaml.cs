using System;
using System.Windows;
using System.Net;
using System.Net.Mail;

namespace WpfMailSender
{
    /// <summary>
    /// Interaction logic for WpfMailSender.xaml
    /// </summary>
    public partial class WpfMailSender : Window
    {
        public WpfMailSender()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, RoutedEventArgs e)
        {
            //var credentials = new NetworkCredential
            //{
            //    UserName = userNameBox.Text,
            //    Password = passwordBox.Password
            //};
            //var emailData = new EmailSendService.Email
            //{
            //    From = userNameBox.Text,
            //    To = toBox.Text,
            //    Subject = subjectBox.Text,
            //    Body = bodyBox.Text
            //};
            //var email = new EmailSendService(credentials, emailData);
            //email.SendMessage();
        }
    }
}