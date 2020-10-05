using System.Collections.Generic;
using System.Linq;
using MailSender.lib.Models;
using MailSender.lib.Service;

namespace WpfTestMailSender.Data
{
    public class TestData
    {
        public static List<Sender> Senders { get; } = Enumerable.Range(1, 10)
            .Select(x => new Sender
            {
                Name = $"Получатель {x}",
                Address = $"Sender_{x}Server.ru"

            })
            .ToList();

        public static List<Recipient> Recipients { get; } = Enumerable.Range(1, 10)
            .Select(x => new Recipient
            {
                Name = $"Отправитель {x}",
                Address = $"Recipient_{x}Server.ru"

            })
            .ToList();

        public static List<Server> Servers { get; } = Enumerable.Range(1, 10)
            .Select(x => new Server
            {
                Address = $"smtp.server{x}.com",
                Login = $"Login-{x}",
                Password = TextEncoder.Encode($"Password-{x}"),
                UseSSL = x % 2 == 0
            })
            .ToList();

        public static List<Message> Messages{ get; } = Enumerable.Range(1, 10)
            .Select(x => new Message
            {
               Subject = $"Сообщение {x}",
               Body = $"Текст сообщения {x}"
            })
            .ToList();
    }
}