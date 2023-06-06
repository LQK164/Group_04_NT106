using MimeKit;
using System;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Mail_detail : Form
    {
        public Mail_detail()
        {
            InitializeComponent();
        }

        private void Mail_detail_Load(object sender, EventArgs e)
        {
            MimeMessage message = Tag as MimeMessage;
            txt_From.Text = message.From.ToString();
            Text = message.Subject;
            txt_To.Text = message.To.ToString();
            txt_Subject.Text = message.Subject;
            txt_Mail_Content.DocumentText = message.HtmlBody;
        }
    }
}