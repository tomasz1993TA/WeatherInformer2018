using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherInformer
{
    public class MailSender
    {
        MailMessage message = new MailMessage();
        public void SendMail(string mailSendTo, string mailSubject, string mailBody)
        {
            message.To.Add(mailSendTo);
            message.Subject = mailSubject;
            message.Body = mailBody;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Send(message);
        }

        public void AddAttachment()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            Attachment filePath = new Attachment(openFileDialog.FileName);
            message.Attachments.Add(filePath);
        }

        public bool IsValidEmailAddress(string email)
        {
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
    }
}
