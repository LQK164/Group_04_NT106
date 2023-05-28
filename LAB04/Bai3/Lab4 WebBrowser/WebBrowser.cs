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
    {   // Khai báo đối tượng WebBrowser
        System.Windows.Forms.WebBrowser webBrowser;
        // Danh sách các liên kết đã truy cập
        List<string> links = new List<string>();
        // Số lượng liên kết đã truy cập
        int countlinks = 0;
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng WebBrowser mới thiết lập chiều dài chiều rộng hiển thị webBrowser 
            webBrowser = new System.Windows.Forms.WebBrowser();
            webBrowser.Height = 500;
            webBrowser.Width = 1080;
            // Thêm đối tượng WebBrowser vào Panel pnWeb
            pnWeb.Controls.Add(webBrowser);
            // Thêm đối tượng WebBrowser vào Panel pnWeb
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAddress.Text))
                // Điều hướng đến địa chỉ URL được nhập
                webBrowser.Navigate(tbAddress.Text);
            // Lưu trữ liên kết đã truy cập vào danh sách
            links.Add(tbAddress.Text);
            countlinks++;
        }

        private void btnDowHTML_Click(object sender, EventArgs e)
        {
            string url = tbAddress.Text; 
            string folderPath = tbPath.Text;
            // Tải và lưu nguồn của trang web
            DownloadWebsiteSource(url, folderPath);
            MessageBox.Show("Download completed!");
        }

        private void DownloadWebsiteSource(string url, string folderPath)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);

            // Lưu trữ nguồn (source) của trang web
            string source = document.DocumentNode.OuterHtml;
            // Lấy tên tệp tin từ URL
            string fileName = Path.GetFileName(url);
            // Kết hợp đường dẫn thư mục và tên tệp tin
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
            // Tải nguồn của trang web
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);
            // Lưu trữ nguồn của trang web vào biến source
            string source = document.DocumentNode.OuterHtml;
            // Hiển thị nguồn trong một cửa sổ Resource
            using (Resource viewSourceForm = new Resource())
            {
                viewSourceForm.SetSource(source);
                viewSourceForm.ShowDialog();
            }
        }
    }
}
