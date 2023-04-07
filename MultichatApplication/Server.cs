using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultichatApplication
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        private TcpListener tcpServer;
        private Thread listenThread;
        private Dictionary<string, TcpClient> dic_clients = new Dictionary<string, TcpClient>();
        private bool listening = true;
        private delegate void SafeCallDelegate(string username, string message);

        private void UpdateChatHistorySafeCall(string username, string message)
        {
            if (lstChatBox.InvokeRequired)
            {
                var method = new SafeCallDelegate(UpdateChatHistorySafeCall);
                lstChatBox.Invoke(method, new object[] { username, message });
            }
            else
            {
                lstChatBox.Items.Add($"{username}: {message}");
            }
        }

        private void Listen()
        {
            tcpServer = new TcpListener(IPAddress.Any, int.Parse(txtServerPort.Text));
            tcpServer.Start();
            try
            {
                while (listening)
                {
                    TcpClient client = tcpServer.AcceptTcpClient();
                    NetworkStream net_stream = client.GetStream();
                    byte[] data = new byte[1024];
                    int byte_count = net_stream.Read(data, 0, data.Length);
                    string username = Encoding.UTF8.GetString(data, 0, byte_count);
                    if (dic_clients.ContainsKey(username))
                    {
                        byte[] response = Encoding.UTF8.GetBytes("This username has already existed!");
                        net_stream.Write(response, 0, response.Length);
                        net_stream.Flush();
                        client.Close();
                    }
                    else if (username == "Administrator")
                    {
                        byte[] response = Encoding.UTF8.GetBytes("This username is reserved!");
                        net_stream.Write(response, 0, response.Length);
                        net_stream.Flush();
                        client.Close();
                    }
                    else
                    {
                        UpdateChatHistorySafeCall("Administrator", $"User {username} has connected succesfully");
                        dic_clients.Add(username, client);
                        Thread receiveThread = new Thread(Receive);
                        receiveThread.IsBackground = true;
                        receiveThread.Start(username);
                    }
                }
            }
            catch
            {
                tcpServer = new TcpListener(IPAddress.Any, int.Parse(txtServerPort.Text));
            }
        }

        private void Broadcast(string username, string message, TcpClient except_this_client)
        {
            byte[] flooding_message = Encoding.UTF8.GetBytes($"{username}: {message}");
            foreach (TcpClient client in dic_clients.Values)
            {
                if (client != except_this_client)
                {
                    NetworkStream net_stream = client.GetStream();
                    net_stream.Write(flooding_message, 0, flooding_message.Length);
                    net_stream.Flush();
                }
            }
        }

        private void Receive(object obj)
        {
            string username = obj.ToString();
            TcpClient client = dic_clients[username];
            NetworkStream net_stream = client.GetStream();
            byte[] data = new byte[1024];
            try
            {
                while (listening)
                {
                    int byte_count = net_stream.Read(data, 0, data.Length);
                    string message = Encoding.UTF8.GetString(data, 0, byte_count);
                    Broadcast(username, message, client);
                    UpdateChatHistorySafeCall(username, message);
                    if (byte_count == 0)
                    {
                        listening = false;
                    }
                }
            }
            catch
            {
                dic_clients.Remove(username);
                client.Close();
                MessageBox.Show($"-----Connection from {username} closed-----");
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            //Nhap so luong client du kien truy cap
            int users_num = int.Parse(txtUserNumber.Text);
            while (users_num > 0)
            {
                frmClient client = new frmClient();
                client.Show();
                users_num--;
            }
            
            //Khoi dong tien trinh cua server
            UpdateChatHistorySafeCall("Administrator", "Monitoring for connections...");
            listenThread = new Thread(new ThreadStart(Listen));
            listenThread.IsBackground = true;
            listenThread.Start();
            this.btnListen.Enabled = false;
            txtServerPort.ReadOnly = txtUserNumber.ReadOnly = true;
        }
    }
}