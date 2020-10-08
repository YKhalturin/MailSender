using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MailSender;

namespace WpfTestMailSender.ViewModels
{
    class ViewModelLocator
    {
        //public static readonly DependencyProperty SelectedRecipientProperty = DependencyProperty.Register("SelectedRecipient", typeof(object), typeof(ViewModelLocator), new PropertyMetadata(default(object)));
        public MainWindowViewModel MainWindowModel => App.Services.GetRequiredService<MainWindowViewModel>();

    }
}