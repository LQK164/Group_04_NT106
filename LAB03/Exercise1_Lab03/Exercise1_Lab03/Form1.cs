namespace Exercise1_Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Client client = new Client();   
            client.Show();
        }
    }
}