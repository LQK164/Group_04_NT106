namespace CallAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            var response = await Rest_Helper.GetAll();
            txtResponse.Text = response.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResponse.Text = null;
            MessageBox.Show ("Deleted");
        }
    }
}