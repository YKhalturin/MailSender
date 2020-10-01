using Microsoft.Extensions.DependencyInjection;
using MailSender;

namespace WpfTestMailSender.ViewModels
{
    class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => App.Services.GetRequiredService<MainWindowViewModel>();
    }
}