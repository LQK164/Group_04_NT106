namespace Lab03_Task1_UDPChatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            Client client = new Client();   
            client.Show();
        }
    }
}