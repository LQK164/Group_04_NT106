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
using System.Xml.Serialization;
using System.Net;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;

namespace Bai4
{
    public partial class frmYou : Form
    {
        public frmYou()
        {
            InitializeComponent();
        }

        private static Socket tcpYou;
        private EndPoint remote_endpoint = (EndPoint)new IPEndPoint(IPAddress.Loopback, 11000);
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

        private void Receive()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                int byte_count = tcpYou.ReceiveFrom(data, ref remote_endpoint);
                if (byte_count == 0)
                {
                    break;
                }
                Packet receivedData = new Packet(data);
                if (receivedData.ChatDataIdentifier == DataIdentifier.Message)
                {
                    UpdateChatHistory($"{receivedData.ChatName}: {receivedData.ChatMessage}");
                }
                if (receivedData.ChatDataIdentifier == DataIdentifier.LogOut)
                {
                    UpdateChatHistory($"-- {receivedData.ChatName} has left --");
                }
                if (receivedData.ChatDataIdentifier == DataIdentifier.File)
                {
                    UpdateChatHistory($"-- {receivedData.ChatName} has sent you a file --");
                    DialogResult dr = MessageBox.Show("Do you want to read it now?",
                                                      "",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show(receivedData.ChatMessage);
                    }
                }
            }
        }

        private void frmYou_Load(object sender, EventArgs e)
        {
            tcpYou = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            EndPoint local_endpoint = (EndPoint)new IPEndPoint(IPAddress.Loopback, 12000);
            tcpYou.Bind(local_endpoint);
            try
            {
                tcpYou.Connect(remote_endpoint);
                Packet sendData = new Packet()
                {
                    ChatDataIdentifier = DataIdentifier.LogIn,
                    ChatName = this.Text,
                    ChatMessage = ""
                };
                byte[] login_message = sendData.GetDataStream();
                tcpYou.SendTo(login_message, remote_endpoint);
                Thread youThread = new Thread(Receive)
                {
                    IsBackground = true
                };
                youThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show("Please type something!");
                return;
            }
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
                MessageBox.Show("Connection has failed!");
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

        private void frmYou_FormClosing(object sender, FormClosingEventArgs e)
        {
            Packet sendData = new Packet()
            {
                ChatDataIdentifier = DataIdentifier.LogOut,
                ChatName = this.Text.Trim(),
                ChatMessage = ""
            };
            if (tcpYou.Connected)
            {
                byte[] logout_message=sendData.GetDataStream();
                tcpYou.SendTo(logout_message, remote_endpoint);
                tcpYou.Shutdown(SocketShutdown.Both);
            }
        }
    }
}