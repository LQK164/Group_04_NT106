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
        Dictionary<int, TcpClient> clientlist;

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                int port = Convert.ToInt32(txtPort.Text);
                ep = new IPEndPoint(IPAddress.Any, port);
                server = new TcpListener(ep);
                clientlist = new Dictionary<int, TcpClient>();
                Thread listen = new Thread(() =>
                {
                    server.Start();
                    Thread addclient = new Thread(() =>
                    {
                        int index = 0;
                        while (true)
                        {
                            TcpClient client = server.AcceptTcpClient();
                            index += 1;
                            clientlist.Add(index, client);
                            Thread receive = new Thread(Receive);
                            receive.IsBackground = true;
                            receive.Start(index);
                        }
                    });
                    addclient.Start();
                });
                listen.IsBackground = true;
                listen.Start();
                btnListen.Enabled = false;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Nhập port của server", "Notice");
            }
        }

        void Receive(object obj)
        {
            int index = (int)obj;
            byte[] Data = new byte[256];
            TcpClient client = clientlist[index];
            String Mes = null;
            NetworkStream stream = client.GetStream();
            int i;
            string ResponseMes = "";
            CheckForIllegalCrossThreadCalls = false;
            while ((i = stream.Read(Data, 0, Data.Length)) != 0)
            {
                Mes = System.Text.Encoding.ASCII.GetString(Data, 0, i);
                txtChat.Text += "Client: " + index + ": " + Mes + "\r\n";
                ResponseMes = "Client" + index + ": " + Mes + "\r\n";
                SendAllClients(ResponseMes);
            }
        }

        void SendAllClients(string ResponseMes)
        {
            byte[] ResponseData = System.Text.Encoding.ASCII.GetBytes(ResponseMes);
            foreach (TcpClient Client in clientlist.Values)
            {
                NetworkStream Stream = Client.GetStream();
                Stream.Write(ResponseData, 0, ResponseData.Length);
            }
        }
    }
}
