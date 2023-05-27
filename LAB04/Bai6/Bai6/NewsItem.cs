using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace Bai6
{
    public partial class ucNewsItem : UserControl
    {
        public ucNewsItem()
        {
            InitializeComponent();
        }

        private string title;
        private string description;
        private string image_url;
        private string reference;

        public string Title
        {
            get { return this.title; }
            set { this.title = value; lblTitle.Text = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; lblDescription.Text = value; }
        }

        public string ImageUrl
        {
            get { return this.image_url; }
            set
            {
                this.image_url = value;
                WebRequest request = WebRequest.Create(value);
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        picImage.Image = Bitmap.FromStream(dataStream);
                    }
                }
            }
        }

        public string Reference
        {
            get { return this.reference; }
            set { this.reference = value; }
        }

        private void ucNewsItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ucNewsItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ucNewsItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmPage page = new frmPage()
            {
                Text = this.title
            };
            frmPage.news_url = this.reference;
            page.Show();
        }
    }
}