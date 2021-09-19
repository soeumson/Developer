using Ecommerce.Core.Model.SettingEmail;
using EcommerceBackEnd.Services;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MimeKit;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Reposiotrys
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _emailSettings;

        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }
       public async Task SendEmailAsync(string email, string subject, string textMessage, string htmlMessage)
       {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress(_emailSettings.SenderName, _emailSettings.SenderEmail));
            mimeMessage.To.Add(MailboxAddress.Parse(email));

            mimeMessage.Subject = subject;
            var builder = new BodyBuilder { TextBody = textMessage, HtmlBody = htmlMessage };
            mimeMessage.Body = builder.ToMessageBody();

            try
            {
                using var client = new SmtpClient();
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                if (_emailSettings.IsDevelopment)
                    await client.ConnectAsync(_emailSettings.MailServer, _emailSettings.MailPort, _emailSettings.UseSsl)
                        .ConfigureAwait(false);
                else
                    await client.ConnectAsync(_emailSettings.MailServer).ConfigureAwait(false);
                await client.AuthenticateAsync(_emailSettings.SenderEmail, _emailSettings.Password).ConfigureAwait(false);
                await client.SendAsync(mimeMessage).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);

                Log.Error("Success send eamil " + "From Email System " + _emailSettings.SenderEmail + "To Email " + email);
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong send eamil", ex + "From Email System " + _emailSettings.SenderEmail + "To Email " + email);
                throw new Exception("Email Invalid.",innerException:new Exception("EMAIL"));
            }
    }
    }
}
