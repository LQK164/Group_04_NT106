using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultichatApplication
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private TcpClient tcpClient;
        private Thread clientThread;
        private bool connecting = true;
        private delegate void SafeCallDelegate(string username, string data);

        private void UpdateChatHistorySafeCall(string username, string data)
        {
            if (lstChatBox.InvokeRequired)
            {
                var method = new SafeCallDelegate(UpdateChatHistorySafeCall);
                lstChatBox.Invoke(method, new object[] { username, data });
            }
            else
            {
                if (username == null)
                {
                    lstChatBox.Items.Add(data);
                }
                else
                {
                    lstChatBox.Items.Add($"{username}: {data}");
                }
            }
        }

        private void Receive()
        {
            NetworkStream net_stream = tcpClient.GetStream();
            byte[] data = new byte[1024];
            try
            {
                while (connecting && tcpClient.Connected)
                {
                    int byte_count = net_stream.Read(data, 0, data.Length);
                    string message = Encoding.UTF8.GetString(data, 0, byte_count);
                    UpdateChatHistorySafeCall(null, message);
                    if (byte_count == 0)
                    {
                        connecting = false;
                    }
                }
            }
            catch
            {
                tcpClient.Close();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint tcpServer = new IPEndPoint(IPAddress.Parse(txtServerIP.Text), int.Parse(txtServerPort.Text));
                tcpClient = new TcpClient();
                tcpClient.Connect(tcpServer);

                //Gui username toi server
                NetworkStream net_stream = tcpClient.GetStream();
                byte[] message = Encoding.UTF8.GetBytes(txtUsername.Text);
                net_stream.Write(message, 0, message.Length);
                net_stream.Flush();

                //Khoi dong tien trinh ben client
                clientThread = new Thread(Receive);
                clientThread.IsBackground = true;
                clientThread.Start();
                txtServerIP.ReadOnly = txtServerPort.ReadOnly = txtUsername.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Connetion failed!");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream net_stream = tcpClient.GetStream();
            byte[] message = Encoding.UTF8.GetBytes(txtMessage.Text);
            net_stream.Write(message, 0, message.Length);
            UpdateChatHistorySafeCall("Me", txtMessage.Text);
            net_stream.Flush();
            txtMessage.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            clientThread = null;
            tcpClient.Close();
            UpdateChatHistorySafeCall(null, "Disconnected now...");
        }
    }
}