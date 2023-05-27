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
using HtmlAgilityPack;

namespace Lab4_WebBrowser
{
    public partial class WebBrowser : Form
    {
        System.Windows.Forms.WebBrowser webBrowser;
        List<string> links = new List<string>();
        int countlinks = 0;
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            webBrowser = new System.Windows.Forms.WebBrowser();
            webBrowser.Height = 500;
            webBrowser.Width = 1080;
            pnWeb.Controls.Add(webBrowser);
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAddress.Text))
                webBrowser.Navigate(tbAddress.Text);
            links.Add(tbAddress.Text);
            countlinks++;
        }

        private void btnDowHTML_Click(object sender, EventArgs e)
        {
            string url = tbAddress.Text; 
            string folderPath = tbPath.Text; 

            DownloadWebsiteSource(url, folderPath);
            MessageBox.Show("Download completed!");
        }

        private void DownloadWebsiteSource(string url, string folderPath)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);

            // Lưu trữ nguồn (source) của trang web
            string source = document.DocumentNode.OuterHtml;
            string fileName = Path.GetFileName(url);
            string filePath = Path.Combine(folderPath, fileName + ".html");
            File.WriteAllText(filePath, source);

            // Download các hình ảnh và file liên quan
            DownloadSource(document.DocumentNode, folderPath);
        }


        void DownloadSource(HtmlAgilityPack.HtmlNode node, string folderPath)
        {
            if (node.NodeType == HtmlAgilityPack.HtmlNodeType.Element)
            {
                // Kiểm tra các thẻ HTML img, link và script
                if (node.Name == "img" || node.Name == "link" || node.Name == "script")
                {
                    // Lấy thuộc tính src hoặc href của thẻ
                    string sourceUrl = node.GetAttributeValue("src", null) ?? node.GetAttributeValue("href", null);

                    if (!string.IsNullOrEmpty(sourceUrl))
                    {
                        // Tạo đường dẫn lưu trữ cho tệp tin
                        string fileName = Path.GetFileName(sourceUrl);
                        string filePath = Path.Combine(folderPath, fileName);

                        // Tải và lưu tệp tin
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(sourceUrl, filePath);
                        }
                    }
                }
            }
            foreach (HtmlAgilityPack.HtmlNode childNode in node.ChildNodes)
            {
                DownloadSource(childNode, folderPath);
            }
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            string url = tbAddress.Text;
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);
            string source = document.DocumentNode.OuterHtml;
            using (Resource viewSourceForm = new Resource())
            {
                viewSourceForm.SetSource(source);
                viewSourceForm.ShowDialog();
            }
        }
    }
}
