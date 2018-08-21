using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Site.Models;

namespace Site.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        private readonly IOptions<ConfigModel> _options;

        public EmailSender(IOptions<ConfigModel> _Options)
        {
            _options = _Options;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            var smtpClient = new SmtpClient
            {
                Host = _options.Value.SmtpConfig.Host, // set your SMTP server name here
                Port = _options.Value.SmtpConfig.Port, // Port 
                EnableSsl = _options.Value.SmtpConfig.Ssl,
                Credentials = new NetworkCredential(_options.Value.SmtpConfig.EmailCredential.User, _options.Value.SmtpConfig.EmailCredential.Password)
            };

            using (var messageItem = new MailMessage(_options.Value.SmtpConfig.EmailCredential.User, email)
            {
                Subject = subject,
                Body = message
            })
            {
                smtpClient.SendMailAsync(messageItem);
                return Task.CompletedTask;
            }
        }
    }
}
