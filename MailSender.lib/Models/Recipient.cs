using MailSender.lib.Models.Base;

namespace MailSender.lib.Models
{
    public class Recipient : Person
    {
        public override string Name { get; set; }
        public override string Address { get; set; }
    }
}