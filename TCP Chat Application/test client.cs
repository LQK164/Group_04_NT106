using System;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Threading;

namespace TCP_server
{
    public partial class test_client : Form
    {
        public test_client()
        {
            InitializeComponent();
        }

        TcpClient client;
        int serverport;
        IPAddress serverAddr;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serverport = Convert.ToInt32(txtPort.Text);
                serverAddr = IPAddress.Parse(txtIP.Text);
                client = new TcpClient();
                client.Connect(serverAddr, serverport);
                Thread receive = new Thread(Receive);
                receive.IsBackground = true;
                receive.Start();
                btnConnect.Enabled = false;
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Không thể kết nối server.", "Notice");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtSend.Text;
            byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
            txtSend.Text = "";
        }

        void Receive()
        {
            byte[] ResponseData = new byte[256];
            String Responsemes = String.Empty;
            NetworkStream stream = client.GetStream();
            int i;
            while ((i = stream.Read(ResponseData, 0, ResponseData.Length)) != 0)
            {
                Responsemes = System.Text.Encoding.ASCII.GetString(ResponseData, 0, i);
                txtChat.Text += Responsemes;
            }
        }

        private void txtSend_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }
    }
}
