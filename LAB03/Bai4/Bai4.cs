using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            frmServer form_server = new frmServer();
            form_server.Show();
        }

        private void btnOpenClient_Click(object sender, EventArgs e)
        {
            frmClient form_client = new frmClient();
            form_client.Show();
        }
    }
}