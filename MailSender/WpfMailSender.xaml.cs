using System;
using System.Windows;
using System.Net;
using System.Net.Mail;
using MailSender.lib;
using WpfTestMailSender.Models;

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

        private void SendButton_Click(object Sender, RoutedEventArgs e)
        {
            if (!(ServersList.SelectedItem is Server server)) return;
            if (!(SendersList.SelectedItem is Sender sender)) return;
            if (!(RecipientsList.SelectedItem is Recipient recipient)) return;
            if (!(MessagesList.SelectedItem is Message message)) return;

            var sendService = new MailSenderService
            {
                ServerAddress = server.Address,
                ServerPort = server.Port,
                UseSSL = server.UseSSL,
                Login = server.Login,
                Password = server.Password,
            };
            try
            {
                var emailData = new MailSenderService.Email
                {
                    SenderAddress = sender.Address,
                    RecipientAddress = recipient.Address,
                    Subject = message.Subject,
                    Body = message.Body
                };
                sendService.SendMessage(emailData);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"Ошибка при отправке почты {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}