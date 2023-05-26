using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace Post_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class info
        {
            public string email { get; set; }
            public string password { get; set; }
            public info(string email, string pass)
            {
                this.email = email;
                this.password = pass;
            }
        }
        private async void btnPost_Click(object sender, EventArgs e)
        {
            string url = txt_url.Text;

            using (HttpClient httpclient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpclient.PostAsJsonAsync(url,
                        new info(email: txt_email.Text, pass: txt_pass.Text));

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        dynamic json_response = JsonConvert.DeserializeObject<dynamic>(responseContent);

                        string token = json_response.token;
                        int id = json_response.id;

                        txt_response.Text += "ID: " + id + "\n";
                        txt_response.Text += "Token: " + token;
                    }
                    else
                    {
                        txt_response.Text = "Error! Please try again";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}