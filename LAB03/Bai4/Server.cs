using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace Bai4
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        private TcpListener tcpServer;
        private Dictionary<string, TcpClient> dic_clients = new Dictionary<string, TcpClient>();
        private delegate void StatusDelegate(string status);

        private void UpdateStatus(string status)
        {
            if (lstChatBox.InvokeRequired)
            {
                var invoker = new StatusDelegate(UpdateStatus);
                lstChatBox.Invoke(invoker, new object[] { status });
            }
            else
            {
                lstChatBox.Items.Add(status);
            }
        }

        private void Broadcast(Packet sendData, TcpClient sender)
        {
            byte[] message = sendData.GetDataStream();
            foreach (TcpClient receiver in dic_clients.Values)
            {
                if (receiver != sender)
                {
                    NetworkStream net_stream = receiver.GetStream();
                    net_stream.Write(message, 0, message.Length);
                    net_stream.Flush();
                }
            }
        }

        private void Receive(object obj)
        {
            TcpClient client = obj as TcpClient;
            while (client.Connected)
            {
                NetworkStream net_stream = client.GetStream();
                byte[] data = new byte[1024];
                int byte_count = net_stream.Read(data, 0, data.Length);
                if (byte_count == 0)
                {
                    break;
                }
                Packet receivedData = new Packet(data);
                Packet sendData = new Packet()
                {
                    ChatDataIdentifier = receivedData.ChatDataIdentifier,
                    ChatName = receivedData.ChatName
                };
                string status = "";
                switch (receivedData.ChatDataIdentifier)
                {
                    case DataIdentifier.LogIn:
                        if (!dic_clients.ContainsKey(receivedData.ChatName))
                        {
                            dic_clients.Add(receivedData.ChatName, client);
                            status = $"-- {receivedData.ChatName} has joined the chat at {client.Client.RemoteEndPoint} --";
                        }
                        sendData.ChatMessage = "";
                        break;

                    case DataIdentifier.LogOut:
                        foreach (KeyValuePair<string, TcpClient> kvp in dic_clients)
                        {
                            if (kvp.Value.Equals(client))
                            {
                                dic_clients.Remove(kvp.Key);
                                break;
                            }
                        }
                        status = $"-- {receivedData.ChatName} has left the chat --";
                        sendData.ChatMessage = $"-- {receivedData.ChatName} has gone offline --";
                        break;

                    case DataIdentifier.Message:
                        status = $"{receivedData.ChatName}: {receivedData.ChatMessage}";
                        sendData.ChatMessage = receivedData.ChatMessage;
                        break;
                }
                Broadcast(sendData, client);
                UpdateStatus(status);
            }
        }

        private void Listen()
        {
            tcpServer = new TcpListener(IPAddress.Any, 10000);
            tcpServer.Start();
            try
            {
                while (true)
                {
                    TcpClient client = tcpServer.AcceptTcpClient();
                    Thread receiveThread = new Thread(Receive)
                    {
                        IsBackground = true
                    };
                    receiveThread.Start(client);
                }
            }
            catch
            {
                tcpServer = new TcpListener(IPAddress.Any, 10000);
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            lstChatBox.Items.Add("Monitoring for connections...");
            this.btnListen.Enabled = false;
            Thread serverThread = new Thread(new ThreadStart(Listen))
            {
                IsBackground = true
            };
            serverThread.Start();
        }
    }
}