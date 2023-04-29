using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace Lab03_Task1_UDPChatApp
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        UdpClient server;
        IPEndPoint ip_end_point;
        int port = 99999;
        int remote_port = 66666;

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                server = new UdpClient(port);
                ip_end_point = new IPEndPoint(IPAddress.Parse(txt_show_message.Text), remote_port);
                server.BeginReceive(new AsyncCallback(onReceive), server);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void onReceive(IAsyncResult AR)
        {
            byte[] buff = server.EndReceive(AR, ref ip_end_point);
            server.BeginReceive(new AsyncCallback(onReceive), server);
            ControlInvoke(txt_show_message, () => txt_show_message.AppendText(Encoding.UTF8.GetString(buff) + Environment.NewLine));
        }
        delegate void UniversalVoidDelegate();

        public static void ControlInvoke(Control control, Action function)
        {
            if (control.IsDisposed || control.Disposing) return;
            if (control.InvokeRequired)
            {
                control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
                return;
            }
            function();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                server.Connect(ip_end_point);
                server.Send(Encoding.UTF8.GetBytes(txt_show_message.Text), txt_show_message.Text.Length);
                txt_show_message.Clear();
            }
            catch
            {
                MessageBox.Show("Gui that bai! Vui long gui lai");
            }
        }
    }
}
