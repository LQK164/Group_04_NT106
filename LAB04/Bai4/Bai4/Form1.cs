using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using static Bai4.Form1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class api_user
        {
            public int id { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string avatar { get; set; }
        }

        public class api_response
        {
            public int page { get; set; }
            public int per_page { get; set; }
            public int total_users { get; set; }
            public int total_pages { get; set; }
            public List<api_user> data { get; set; }
        }

        private readonly HttpClient httpClient = new HttpClient();
        api_response response = new api_response();
        int counting_page = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            flpn_upload.VerticalScroll.Visible = true;
            Get_api(counting_page);
        }

        private Image Download(string url)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(url);
                    using (var stream = new System.IO.MemoryStream(data))
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public async void Get_api(int page_count)
        {
            try
            {
                var responding = await httpClient.GetAsync("https://reqres.in/api/users?page=" + page_count.ToString());
                responding.EnsureSuccessStatusCode();
                var json = await responding.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<api_response>(json);

                Page.Text = response.page.ToString();
                user_per_page.Text = response.per_page.ToString();
                total_pages.Text = response.total_pages.ToString();
                total_users.Text = response.total_users.ToString();
                string avtURL;
                Image img;
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Value = 0;
                progressBar.Style = ProgressBarStyle.Continuous;
                for (int i = 0; i < response.per_page; i++)
                {
                    Label nameLabel = new Label();
                    nameLabel.Text = response.data[i].first_name + " " + response.data[0].last_name;
                    nameLabel.AutoSize = true;
                    nameLabel.Font = new Font(nameLabel.Font.FontFamily, 12, FontStyle.Bold);
                    flpn_upload.Controls.Add(nameLabel);
                    Label emailLabel = new Label();
                    emailLabel.Text = response.data[i].email;
                    emailLabel.AutoSize = true;
                    emailLabel.Font = new Font(emailLabel.Font.FontFamily, 10);
                    flpn_upload.Controls.Add(emailLabel);
                    PictureBox avatar = new PictureBox();
                    avatar.Size = new Size(150, 150);
                    avtURL = response.data[i].avatar;
                    img = Download(avtURL);
                    avatar.Image = img;
                    flpn_upload.Controls.Add(avatar);
                    if (i == response.per_page - 1) progressBar.Value = 100;
                    else progressBar.Value += 100 / response.per_page;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (counting_page <= 0)
            {
                MessageBox.Show("Không thể lùi!");
            }

            else
            {
                counting_page--;
                flpn_upload.Controls.Clear();
                Get_api(counting_page);
            }

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (counting_page + 1 > response.total_pages)
            {
                MessageBox.Show("Không thể tiến!");
            }

            else
            {
                counting_page++;
                flpn_upload.Controls.Clear();
                Get_api(counting_page);
            }
        }
    }
}