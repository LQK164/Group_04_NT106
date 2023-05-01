using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace TCP_server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        TcpListener server;
        IPEndPoint ep;

        private void btnListen_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(8888);
            ep = new IPEndPoint(IPAddress.Any, port);
            server = new TcpListener(ep);
            Thread lis = new Thread(() => Listen(server));
            txtChat.Text += "Server starts\r\n"
                          + "Waiting for connection...\r\n";
            lis.Start();
        }

        void Listen(TcpListener listener)
        {
            listener.Start();
            CheckForIllegalCrossThreadCalls = false;
            btnListen.Enabled = false;
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                txtChat.Text += "Connected from " + client.Client.RemoteEndPoint +"\r\n";
                Receive(client);
                txtChat.Text += "Disconnected from " + client.Client.RemoteEndPoint + "\r\n";
            }
        }

        void Receive(TcpClient client)
        {
            byte[] Data = new byte[256];
            String Mes = null;
            NetworkStream stream = client.GetStream();
            int i;
            while ((i = stream.Read(Data, 0, Data.Length)) != 0)
            {
                Mes = System.Text.Encoding.UTF8.GetString(Data, 0, i);
                txtChat.Text += "Client: " + Mes + "\r\n";
            }
        }

    }
}
