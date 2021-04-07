﻿using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Areas.Admin.Services
{
    public class SendEmailService
    {
        public bool Seed( string EmailTo,string MessageEmail)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Admin", "ars.codedy@gmail.com"));
            message.To.Add(new MailboxAddress("Customer", EmailTo));
            message.Subject = "Authenticate service registration at Code";
            message.Body = new TextPart("plain")
            {
                Text = MessageEmail
            };
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("ars.codedy@gmail.com", "qpnirdwtvkgtmhyq");
                client.Send(message);
                client.Disconnect(true);
            }
            return true;
        }
    }
}
