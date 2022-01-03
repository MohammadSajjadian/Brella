﻿//using MailKit.Net.Smtp;
//using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Services.EmailService
{
    public class Send : IEmail
    {
        async Task IEmail.Send(string subject, string body, string receiver)
        {
            var mailmessage = new MailMessage("toloe.sanat.site@gmail.com", receiver)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };

            var smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential("toloe.sanat.site@gmail.com", "Friday1380"),
                EnableSsl = true
            };

            await smtpClient.SendMailAsync(mailmessage);
        }
    }
}
