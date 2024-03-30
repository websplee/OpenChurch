using CrystalBLCore.BusinessServices.Interfaces;
using CrystalBLCore.Models;
using CrystalBLCore.Models.Interfaces;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalBLCore.BusinessServices
{
    public class EmailService : IEmailService
    {
        public readonly EmailConfiguration _emailConfiguration;

        public EmailService(EmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }

        public List<EmailMessage> ReceiveEmail(int maxCount = 10)
        {
            using (var emailClient = new Pop3Client())
            {
                emailClient.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, true);

                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

                emailClient.Authenticate(_emailConfiguration.PopUsername, _emailConfiguration.PopPassword);

                List<EmailMessage> emails = new List<EmailMessage>();
                for (int i = 0; i < emailClient.Count && i < maxCount; i++)
                {
                    var message = emailClient.GetMessage(i);
                    var emailMessage = new EmailMessage
                    {
                        Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody : message.TextBody,
                        Subject = message.Subject
                    };
                    emailMessage.ToAddresses.AddRange(message.To.Select(x => (MailboxAddress)x).Select(x => new EmailAddress { Address = x.Address, Name = x.Name }));
                    emailMessage.FromAddresses.AddRange(message.From.Select(x => (MailboxAddress)x).Select(x => new EmailAddress { Address = x.Address, Name = x.Name }));
                    emails.Add(emailMessage);
                }

                return emails;
            }
        }

        public async Task Send(EmailMessage emailMessage)
        {
            // Compose a message
            MimeMessage mail = new MimeMessage();
            //mail.From.Add(new MailboxAddress("Inventory Control System", "hchinyama@crystalisedliquid.com"));
            mail.From.Add(new MailboxAddress(emailMessage.FromAddresses[0].Name, emailMessage.FromAddresses[0].Address));
            //mail.To.Add(new MailboxAddress("H Gmail", "hmsplee@gmail.com"));
            mail.To.Add(new MailboxAddress(emailMessage.ToAddresses[0].Name, emailMessage.ToAddresses[0].Address));
            //mail.To.Add(new MailboxAddress("H Gmail", "cynthiambulo@gmail.com"));
            //mail.Subject = "Mail";
            mail.Subject = emailMessage.Subject;
            mail.Body = new TextPart("html")
            {
                Text = emailMessage.Content,
            };
            using (var emailClient = new SmtpClient())
            {
                emailClient.ServerCertificateValidationCallback = (s, c, h, e) => true;

                //The last parameter here is to use SSL (Which you should!)
                await emailClient.ConnectAsync(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, false);

                //Remove any OAuth functionality as we won't be using it. 
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

                await emailClient.AuthenticateAsync(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);

                await emailClient.SendAsync(mail);

                await emailClient.DisconnectAsync(true);
            }
        }
    }
}
