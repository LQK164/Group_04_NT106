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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Bai6
{
    public partial class frmBai6 : Form
    {
        public frmBai6()
        {
            InitializeComponent();
        }

        private List<ucNewsItem> newsList = new List<ucNewsItem>();

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

        private void btnGet_Click(object sender, EventArgs e)
        {
            string title = "";
            string description = "";
            string image_url = "";
            string reference = "";
            int news_count = 0;
            progressBar.Value = progressBar.Minimum;

            string url = txtUrl.Text;
            string htmlScript = GetHtml(url);
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(htmlScript);
            HtmlNodeCollection nodes = htmlDocument.DocumentNode.SelectNodes("//article");
            
            foreach (HtmlNode node in nodes)
            {
                HtmlNode title_node = node.SelectSingleNode(".//h3[@class='title-news']");
                if (title_node != null)
                {
                    title = title_node.InnerText;
                }

                HtmlNode description_node = node.SelectSingleNode(".//p[@class='description']");
                if (description_node != null)
                {
                    description = description_node.InnerText;
                }

                HtmlNode image_node = node.SelectSingleNode(".//img");
                if (image_node != null)
                {
                    image_url = image_node.Attributes["src"].Value;
                    if (!image_url.Contains("https://"))
                    {
                        image_url = image_node.Attributes["data-src"].Value;
                    }
                }

                HtmlNode reference_node = node.SelectSingleNode(".//a");
                if (reference_node != null)
                {
                    reference = reference_node.GetAttributeValue("href", "");
                }

                ucNewsItem post = new ucNewsItem()
                {
                    Title = title,
                    Description = description,
                    ImageUrl = image_url,
                    Reference = reference
                };

                if (!newsList.Contains(post))
                {
                    newsList.Add(post);
                }

                news_count++;
                progressBar.Value = news_count * 100 / nodes.Count;
            }

            progressBar.Value = progressBar.Maximum;

            foreach (ucNewsItem post in newsList)
            {
                fpnDisplay.Controls.Add(post);
            }
        }
    }
}