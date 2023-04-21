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
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Security.Policy;

namespace CallingWebAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task<Object[]> GetObjectAsync(string path)
        {
            List<Object> obj = new List<Object>();

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                obj = await response.Content.ReadAsAsync<List<Object>>();
            }
            return obj.ToArray();
        }

        private async Task<NhanVien[]> GetNhanVienAsync(string path)
        {
            List<NhanVien> list = new List<NhanVien>();

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                list = await response.Content.ReadAsAsync<List<NhanVien>>();
            }
            return list.ToArray();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();

            string url = "https://jsonplaceholder.typicode.com/todos";
            Object[] objects = await GetObjectAsync(url);
            int i = 1;
            foreach (var obj in objects)
            {
                rtbResult.AppendText($"Object {i}:" + '\n');
                rtbResult.AppendText(obj.userId.ToString() + '\n'
                                    +obj.id.ToString() + '\n'
                                    +obj.title + '\n'
                                    +obj.completed + '\n' + '\n');
                i++;
            }
        }

        private async void btnCall_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();

            HttpClient client = new HttpClient();
            string url = "http://localhost:3000/nhanvien";

            // Get information of nhan vien
            NhanVien[] infos = await GetNhanVienAsync(url);
            int i = 1;
            foreach (var info in infos)
            {
                rtbResult.AppendText($"Nhan vien {i}:" + '\n');
                rtbResult.AppendText(info.manv + '\n' +
                                    info.hoten + '\n' +
                                    info.dienthoai + '\n' +
                                    info.ngvl + '\n' + '\n');
            }
        }
    }
}