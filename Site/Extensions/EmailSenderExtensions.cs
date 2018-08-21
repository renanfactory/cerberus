using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Site.Services;

namespace Site.Extensions
{
    public static class EmailSenderExtensions
    {
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string password, string link)
        {
            var emailBody = "";
            var fileStream = new FileStream("Template/e-mail.tmpl", FileMode.Open);

            using (StreamReader reader = new StreamReader(fileStream))
            {
                emailBody += reader.ReadToEnd();
            }

            var mensagem = $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(link)}'>clicking here</a>.";

            emailBody = emailBody.Replace("{usuario}", email).Replace("{senha}", password).Replace("{mensagem}", mensagem);

            return emailSender.SendEmailAsync(email, "Confirm your email", emailBody);
        }

        public static Task SendResetPasswordAsync(this IEmailSender emailSender, string email, string callbackUrl)
        {
            return emailSender.SendEmailAsync(email, "Reset Password",
                $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
        }
    }
}

