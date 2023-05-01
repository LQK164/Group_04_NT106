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

namespace Exercise1_Lab03
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        IPEndPoint ip_end_point;
        UdpClient server;
        int remote_port = 55555;
        int port = 44444;

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                server.Connect(ip_end_point);
                server.Send(Encoding.UTF8.GetBytes(txt_send.Text), txt_send.Text.Length);
                txt_send.Clear();
            }
            catch
            {
                MessageBox.Show("Send failed! Please send again!");
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                server = new UdpClient(port);
                ip_end_point = new IPEndPoint(IPAddress.Parse(txt_ip_add.Text), remote_port);
                server.BeginReceive(new AsyncCallback(onReceive), server);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onReceive(IAsyncResult AR)
        {
            byte[] buff = server.EndReceive(AR, ref ip_end_point);
            server.BeginReceive(new AsyncCallback(onReceive), server);
            ControlInvoke(txt_show_mes, () => txt_show_mes.AppendText("Server: " + Encoding.UTF8.GetString(buff) + Environment.NewLine));
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
    }
}
