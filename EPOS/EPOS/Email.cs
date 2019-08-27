using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace EPOS
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("eposappemail@gmail.com");
                mail.To.Add(txtRecipientEmail.Text);
                mail.Subject = txtSubj.Text;
                mail.Body = txtEmailBody.Text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("eposappemail@gmail.com", "Bakery!!22##");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEmailMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Close();
            mainMenu.Show();
        }
    }
}
