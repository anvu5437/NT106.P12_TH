using System;
using System.Windows.Forms;

namespace LAB3
{
    public partial class BT4_Dashboard : Form
    {
        public BT4_Dashboard()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            BT4_Server serverForm = new BT4_Server();
            serverForm.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            BT4_Client clientForm = new BT4_Client();
            clientForm.Show();
        }
    }
}
