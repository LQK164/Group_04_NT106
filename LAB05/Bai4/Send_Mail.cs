using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Bai4
{
    public partial class Send_Mail : Form
    {
        public Send_Mail()
        {
            InitializeComponent();
        }

        SMTP_Client_Info client_info = new SMTP_Client_Info();

        private void Send_Mail_Load(object sender, EventArgs e)
        { 
            client_info = Tag as SMTP_Client_Info;
            txt_From.Text = client_info.Get_Name();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txt_Attachment.Text = ofd.FileName;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient();
            client.Host = client_info.Get_Host();
            client.Port = client_info.Get_Port();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(client_info.Get_Name(), client_info.Get_Pass());
            client.EnableSsl = true;
            
            MailMessage message = new MailMessage();
            message.From = new MailAddress(txt_From.Text, txt_Name.Text);
            message.To.Add(txt_To.Text);
            message.Subject = txt_Subject.Text;
            if (Check_HTML.Checked)
            {
                message.IsBodyHtml = true;
            }
            else
            {
                message.IsBodyHtml = false;
            }
            message.Body = txt_Mail_Content.Text;
            Attachment attachment = new Attachment(txt_Attachment.Text);
            message.Attachments.Add(attachment);
            client.Send(message);
            MessageBox.Show("Complete");
        }
    }
}