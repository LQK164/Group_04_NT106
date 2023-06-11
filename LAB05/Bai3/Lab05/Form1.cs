using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Mime;
using OpenPop.Pop3;

namespace Lab05
{
    //email: anhngo051203@gmail.com
    //pwd: fwhpgnazychvlcnc
    public partial class Form1 : Form
    {
        private Pop3Client pop3Client;
        private List<OpenPop.Mime.Message> messages;

        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            string server = "pop.gmail.com"; // Địa chỉ máy chủ POP3 của Gmail
            int port = 995; // Cổng kết nối POP3 của Gmail
            string username = tbEmail.Text; // Tên người dùng của email
            string password = tbPassword.Text; // Mật khẩu của email
            int limit = 5; // Số lượng email muốn hiển thị

            pop3Client = new Pop3Client();

            try
            {
                pop3Client.Connect(server, port, true); // Kết nối tới máy chủ POP3
                pop3Client.Authenticate(username, password); // Xác thực đăng nhập vào email

                int messageCount = pop3Client.GetMessageCount(); // Lấy số lượng email trong hộp thư
                int startIndex = messageCount - limit + 1; // Vị trí bắt đầu lấy email
                int endIndex = messageCount; // Vị trí kết thúc lấy email

                // Tạo các cột cho DataGridView hiển thị thông tin email
                dataGridView1.Columns.Add("Subject", "Subject");
                dataGridView1.Columns.Add("From", "From");
                dataGridView1.Columns.Add("Date", "Date");
                dataGridView1.Columns["Subject"].ReadOnly = true;
                dataGridView1.Columns["From"].ReadOnly = true;
                dataGridView1.Columns["Date"].ReadOnly = true;

                // Lặp qua các email từ vị trí bắt đầu đến vị trí kết thúc
                for (int i = endIndex; i >= startIndex; i--)
                {
                    OpenPop.Mime.Message message = pop3Client.GetMessage(i); // Lấy thông tin của email
                    string subject = message.Headers.Subject; // Lấy chủ đề của email
                    string from = message.Headers.From.Address; // Lấy địa chỉ người gửi của email
                    DateTime date = message.Headers.DateSent; // Lấy ngày gửi của email

                    // Thêm thông tin của email vào DataGridView
                    dataGridView1.Rows.Add(subject, from, date);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message); // Hiển thị thông báo lỗi nếu có lỗi xảy ra
            }
            finally
            {
                if (pop3Client != null && pop3Client.Connected)
                    pop3Client.Disconnect(); // Ngắt kết nối sau khi hoàn thành việc lấy email
            }
        }
    }
}
