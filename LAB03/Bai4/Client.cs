using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bai4
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private TcpClient tcpClient;
        IPEndPoint server_endpoint = new IPEndPoint(IPAddress.Parse("172.20.10.5"), 8080);
        private delegate void MessageDelegate(string message);
        private delegate void ParticipantsDelegate(string username);
        private delegate void OnConnectEventHandler(bool is_connected);

        private void DisplayMessage(string message)
        {
            if (lstChatBox.InvokeRequired)
            {
                var invoker = new MessageDelegate(DisplayMessage);
                lstChatBox.Invoke(invoker, new object[] { message });
            }
            else
            {
                if (message.Contains('\n'))
                {
                    message = message.Replace('\n', ' ');
                }
                lstChatBox.Items.Add(message);
            }
        }

        private void UpdateParticipants(string username)
        {
            if (lstParticipants.InvokeRequired)
            {
                var invoker = new ParticipantsDelegate(UpdateParticipants);
                lstParticipants.Invoke(invoker, new object[] { username });
            }
            else
            {
               lstParticipants.Items.Add(username);
            }
        }

        private void Receive()
        {
            while (true)
            {
                NetworkStream net_stream = tcpClient.GetStream();
                byte[] data = new byte[1024];
                int byte_count = net_stream.Read(data, 0, data.Length);
                if (byte_count == 0)
                {
                    break;
                }
                Packet receivedData = new Packet(data);
                if (receivedData.ChatDataIdentifier == DataIdentifier.Message)
                {
                    DisplayMessage($"{receivedData.ChatName}: {receivedData.ChatMessage}");
                    if (!lstParticipants.Items.Contains(receivedData.ChatName))
                    {
                        UpdateParticipants(receivedData.ChatName);
                    }
                }
                else
                {
                    if (receivedData.ChatMessage != "")
                    {
                        DisplayMessage(receivedData.ChatMessage);
                    }
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please type your username!");
                return;
            }
            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(server_endpoint);
                this.Text = txtUsername.Text.Trim();
                this.btnConnect.Enabled = false;
                Packet sendData = new Packet()
                {
                    ChatDataIdentifier = DataIdentifier.LogIn,
                    ChatName = txtUsername.Text.Trim(),
                    ChatMessage = ""
                };
                byte[] data = sendData.GetDataStream();
                NetworkStream net_stream = tcpClient.GetStream();
                net_stream.Write(data, 0, data.Length);
                net_stream.Flush();
                Thread clientThread = new Thread(Receive)
                {
                    IsBackground = true
                };
                clientThread.Start();
            }
            catch
            {
                MessageBox.Show("Connection failed!");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient == null)
                {
                    MessageBox.Show("Please connect initially!");
                    return;
                }
                if (string.IsNullOrEmpty(txtMessage.Text))
                {
                    MessageBox.Show("Please type something!");
                    return;
                }
                Packet sendData = new Packet()
                {
                    ChatDataIdentifier = DataIdentifier.Message,
                    ChatName = txtUsername.Text.Trim(),
                    ChatMessage = txtMessage.Text
                };
                byte[] data = sendData.GetDataStream();
                NetworkStream net_stream = tcpClient.GetStream();
                net_stream.Write(data, 0, data.Length);
                net_stream.Flush();
                DisplayMessage($"Me: {txtMessage.Text}");
                txtMessage.Text = string.Empty;
                txtUsername.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Connection has closed!");
            }
        }

        private void lstParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstParticipants.SelectedIndex;
            if (index != -1)
            {
                // Me is similar to Server
                frmMe me = new frmMe()
                {
                    Text = txtUsername.Text.Trim()
                };
                me.Show();

                // You is similar to Client
                frmYou you = new frmYou()
                {
                    Text = lstParticipants.Items[index].ToString()
                };
                you.Show();
            }
            else
            {
                MessageBox.Show("There is not any participants!");
            }
        }

        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Packet sendData = new Packet()
            {
                ChatDataIdentifier = DataIdentifier.LogOut,
                ChatName = txtUsername.Text.Trim(),
                ChatMessage = ""
            };
            if (tcpClient.Connected)
            {
                byte[] logout_message = sendData.GetDataStream();
                NetworkStream net_stream = tcpClient.GetStream();
                net_stream.Write(logout_message, 0, logout_message.Length);
                net_stream.Flush();
                tcpClient.Client.Shutdown(SocketShutdown.Send);
            }
        }
    }
}