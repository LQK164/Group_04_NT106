using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets; 
using System.Threading; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telnet_TCP_listener
{
    public partial class TCPlistener : Form
    {
        private TCPlistener Server; 
        public TCPlistener()
        {
            InitializeComponent();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread ServerThread = new Thread(new ThreadStart(StartUnsafeThread)); 
            ServerThread.Start();
        }

        private void StartUnsafeThread ()
        {
            int byteReceived = 0;
            byte[] recv = new byte[1024];
            Socket clientSocket;
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1); 
            clientSocket = listenerSocket.Accept();
            listViewCommand.Items.Add(new ListViewItem("New Client Connected"));
            while(clientSocket.Connected)
            {
                string text = " ";
                do
                {
                    byteReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                    listViewCommand.Items.Add(new ListViewItem(text));
                }while(text[text.Length - 1] != '\n');
                listenerSocket.Close(); 
            }
        }
    }
}
