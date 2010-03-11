﻿using System.Net.Mail;

namespace Redux.Web.UI.Models
{
    public class SmtpClientProxy : ISmtpClient
    {
        private readonly SmtpClient _smtpClient;

        public SmtpClientProxy(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        #region ISmtpClient Members

        public void Send(MailMessage mailMessage)
        {
            _smtpClient.Send(mailMessage);
        }

        #endregion
    }
}