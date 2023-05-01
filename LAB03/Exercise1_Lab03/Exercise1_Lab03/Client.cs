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

namespace Exercise1_Lab03
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        UdpClient client;
        IPEndPoint ip_end_point;
        int port = 55555;
        int remote_port = 44444;

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new UdpClient(port);
                ip_end_point = new IPEndPoint(IPAddress.Parse(txt_ip_add.Text), remote_port);
                client.BeginReceive(new AsyncCallback(onReceive), client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onReceive(IAsyncResult AR)
        {
            byte[] buff = client.EndReceive(AR, ref ip_end_point);
            client.BeginReceive(new AsyncCallback(onReceive), client);
            ControlInvoke(txt_show_mes, () => txt_show_mes.AppendText("Client: " + Encoding.UTF8.GetString(buff) + Environment.NewLine));
        }

        delegate void UniversalVoidDelegate();

        public static void ControlInvoke(Control control, Action function)
        {
            if (control.IsDisposed || control.Disposing)
                return;
            if (control.InvokeRequired)
            {
                control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
                return;
            }
            function();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(ip_end_point);
                client.Send(Encoding.UTF8.GetBytes(txt_send.Text), txt_send.Text.Length);
            }
            catch
            {
                MessageBox.Show("Send failed! Please send again!");
            }
        }
    }
}
