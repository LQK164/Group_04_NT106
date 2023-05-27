using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class frmPage : Form
    {
        public frmPage()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
        }

        public static string news_url;

        private string GetHtml(string url)
        {
            string htmlScript = "";
            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    htmlScript = reader.ReadToEnd();
                }
            }
            return htmlScript;
        }

        private void frmPage_Load(object sender, EventArgs e)
        {
            string htmlScript = GetHtml(news_url);
            webBrowser.DocumentText = htmlScript;
        }
    }
}