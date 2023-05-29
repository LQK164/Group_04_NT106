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

namespace Bai1_Bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            string URL = txt_URL.Text;
            string fileURL = txt_Destination.Text;
            string WebHTML = "";
            WebHTML = getHTML(txt_URL.Text);
            txt_Content.Text = WebHTML;
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(URL);
            myClient.DownloadFile(URL, fileURL);
        }

        private string getHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }
    }
}
