using MailKit.Security;
using MimeKit;
using MimeKit.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WebApiSkeleton.Core.Domain;
using WebApiSkeleton.Core.Options;

namespace WebApiSkeleton.Core.Helpers
{

    public class MailManage
    {
        private readonly MailOptions _mailOptions;

        public MailManage(MailOptions mailOptions)
        {
            _mailOptions = mailOptions;
        }

        private void SendMessage(MimeMessage mimeMessage)
        {
            SmtpClient smtpClient = new SmtpClient();

            smtpClient.ConnectAsync(_mailOptions.Server, _mailOptions.Port, SecureSocketOptions.None);
            
            smtpClient.SendAsync(mimeMessage);

            smtpClient.DisconnectAsync(true);

        }

        public string CreateMessage(string messageData)
        {
            string retdat = "";
            try
            {
                MimeMessage mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress("TEST Mail", _mailOptions.FromAddress));
                mimeMessage.To.Add(new MailboxAddress("Ayaz Asgarov", "asgarov.ayaz@gmail.com"));
                mimeMessage.Subject = "My First Email";

                BodyBuilder bodyBuilder = new BodyBuilder();

                using (StreamReader SourceReader = System.IO.File.OpenText(@"Email\activate_user.html"))
                {
                    bodyBuilder.HtmlBody = SourceReader.ReadToEnd();
                }

                mimeMessage.Body = bodyBuilder.ToMessageBody();

                this.SendMessage(mimeMessage);
            }
            catch (Exception e)
            {
                retdat = e.Message;
            }

            return retdat;
        }



    }
}
