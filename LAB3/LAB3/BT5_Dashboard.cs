using System;
using System.Windows.Forms;

namespace LAB3
{
    public partial class BT5_Dashboard : Form
    {
        public BT5_Dashboard()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            BT5_Server serverForm = new BT5_Server();
            serverForm.Show();
            this.Hide(); // Ẩn form dashboard nếu muốn
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            BT5_Client clientForm = new BT5_Client();
            clientForm.Show();
            this.Hide(); // Ẩn form dashboard nếu muốn
        }
    }
}
