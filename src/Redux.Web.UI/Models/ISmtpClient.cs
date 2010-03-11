using System.Net.Mail;

namespace Redux.Web.UI.Models
{
    public interface ISmtpClient
    {
        void Send(MailMessage mailMessage);
    }
}