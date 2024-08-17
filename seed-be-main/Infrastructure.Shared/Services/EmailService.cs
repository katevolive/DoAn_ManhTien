using Domain.Settings;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Infrastructure.Shared.Services
{
    public class EmailService : IEmailService
    {
        public MailSettings MailSettings { get; }
        public ILogger<EmailService> Logger { get; }

        public EmailService(IOptions<MailSettings> mailSettings,ILogger<EmailService> logger)
        {
            MailSettings = mailSettings.Value;
            Logger = logger;
        }

        public async Task SendAsync(EmailRequest request)
        {
            try
            {
                // create message
                var email = new MailMessage
                {
                    To = { request.To },
                    From = new MailAddress(MailSettings.EmailFrom),
                    Subject = request.Subject,
                    Body = request.Body,
                    IsBodyHtml = true
                };

                using var smtp = new SmtpClient(MailSettings.SmtpHost, MailSettings.SmtpPort)
                {
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(MailSettings.SmtpUser, MailSettings.SmtpPass),
                    EnableSsl = true,
                };

                await smtp.SendMailAsync(email);
            }
            catch (System.Exception ex)
            {
                Logger.LogError(ex.Message, ex);
            }
        }

    }
}
