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
using System.IO;

namespace Bai4
{
    public partial class frmMe : Form
    {
        public frmMe()
        {
            InitializeComponent();
        }

        private Socket tcpMe;
        private Socket tcpYou;
        //public static Socket tcpMe = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //public static Socket tcpMe;
        //private bool invokeInProgress = false;
        //private bool stopInvoking = false;
        private EndPoint remote_endpoint = (EndPoint)new IPEndPoint(IPAddress.Loopback, 12000);
        private delegate void SafeCallDelegate(string status);

        private void UpdateChatHistory(string status)
        {
            if (rtbChatBox.InvokeRequired)
            {
                var invoker = new SafeCallDelegate(UpdateChatHistory);
                rtbChatBox.Invoke(invoker, new object[] { status });
            }
            else
            {
                if (status.Contains('\n'))
                {
                    status = status.Replace('\n', ' ');
                }
                rtbChatBox.AppendText(status + '\n');
            }
        }

        private void Listen()
        {
            tcpMe = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            EndPoint local_endpoint = (EndPoint)new IPEndPoint(IPAddress.Loopback, 11000);
            tcpMe.Bind(local_endpoint);
            tcpMe.Listen(1);
            while (true)
            {
                tcpYou = tcpMe.Accept();
                while (tcpYou.Connected)
                {
                    byte[] data = new byte[1024];
                    int byte_count = tcpYou.ReceiveFrom(data, ref remote_endpoint);
                    if (byte_count == 0)
                    {
                        break;
                    }
                    Packet receivedData = new Packet(data);
                    string status = "";
                    status = "";
                    switch (receivedData.ChatDataIdentifier)
                    {
                        case DataIdentifier.LogIn:
                            status = $"-- Now, you can talk to {receivedData.ChatName} --";
                            break;

                        case DataIdentifier.LogOut:
                            status = $"-- {receivedData.ChatName} has left --";
                            break;

                        case DataIdentifier.Message:
                            status = $"{receivedData.ChatName}: {receivedData.ChatMessage}";
                            break;
                        case DataIdentifier.File:
                            status = $"-- {receivedData.ChatName} has sent you a file --";
                            DialogResult dr = MessageBox.Show("Do you want to read it now?",
                                                      "",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Question);
                            if (dr == DialogResult.OK)
                            {
                                MessageBox.Show(receivedData.ChatMessage);
                            }
                            break;
                    }
                    UpdateChatHistory(status);
                }
            }
        }

        private void frmMe_Load(object sender, EventArgs e)
        {
            Thread meThread = new Thread(new ThreadStart(Listen));
            meThread.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Packet sendData = new Packet()
                {
                    ChatDataIdentifier = DataIdentifier.Message,
                    ChatName = this.Text,
                    ChatMessage = txtMessage.Text
                };
                byte[] data = sendData.GetDataStream();
                tcpYou.SendTo(data, remote_endpoint);
                UpdateChatHistory($"Me: {txtMessage.Text}");
                txtMessage.Clear();
            }
            catch
            {
                tcpMe.Close();
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Packet sendData = null;
            string file_message = "";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        StreamReader sr = new StreamReader(fs);
                        file_message = sr.ReadToEnd();
                    }
                    sendData = new Packet()
                    {
                        ChatDataIdentifier = DataIdentifier.File,
                        ChatName = this.Text,
                        ChatMessage = file_message
                    };
                }
                byte[] data = sendData.GetDataStream();
                tcpYou.SendTo(data, remote_endpoint);
                UpdateChatHistory($"-- You have sent a file {ofd.FileName}");
            }
            catch
            {
                MessageBox.Show("Please choose a file!");
            }
        }

        private void frmMe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Packet sendData = new Packet()
            {
                ChatDataIdentifier = DataIdentifier.LogOut,
                ChatName = this.Text.Trim(),
                ChatMessage = ""
            };
            byte[] logout_message = sendData.GetDataStream();
            tcpYou.SendTo(logout_message, remote_endpoint);
            tcpYou.Shutdown(SocketShutdown.Send);
        }
    }
}