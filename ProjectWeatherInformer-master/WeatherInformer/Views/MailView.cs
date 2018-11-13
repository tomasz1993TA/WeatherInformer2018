using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Configuration;
using System.Configuration;
using System.Text.RegularExpressions;

namespace WeatherInformer
{
    public partial class MailView : Form
    {        
        public MailSender MailSender { get; set; }

        public MailView()
        {
            InitializeComponent();
            MailSender = new MailSender();
        }        

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!MailSender.IsValidEmailAddress(txtbSendTo.Text))
            {
                MessageBox.Show("Wpisano niepoprawny adres e-mail!");
            }
            else
            {
                MailSender.SendMail(txtbSendTo.Text, txtbSubject.Text, rtxtbBody.Text);
            }
            
            Close();
        }                

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            MailSender.AddAttachment();
        }        
    }
}
