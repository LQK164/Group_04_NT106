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

namespace Lab03_Task1_UDPChatApp
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        UdpClient client;
        IPEndPoint ip_end_point;
        int port = 99999;
        int remote_port = 66666;

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new UdpClient(port);
                ip_end_point = new IPEndPoint(IPAddress.Parse(txt_IP.Text), remote_port);
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
            ControlInvoke(txt_show_message, () => txt_show_message.AppendText(Encoding.UTF8.GetString(buff) + Environment.NewLine));
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

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(ip_end_point);
                client.Send(Encoding.UTF8.GetBytes(txt_Send.Text), txt_Send.Text.Length);
                txt_Send.Clear();
            }
            catch
            {
                MessageBox.Show("Gui that bai! Vui long gui lai");
            }
        }
    }
}
