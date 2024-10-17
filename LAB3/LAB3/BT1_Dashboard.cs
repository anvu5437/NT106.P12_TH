using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class BT1_Dashboard : Form
    {
        public BT1_Dashboard()
        {
            InitializeComponent();
        }

        private void UDPserverbtn_Click(object sender, EventArgs e)
        {
            BT1_Server serverForm = new BT1_Server();
            serverForm.Show();
        }

        private void UDPClientbtn_Click(object sender, EventArgs e)
        {
            BT1_Client clientForm = new BT1_Client();
            clientForm.Show();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            mainMenu mhc = (mainMenu)Application.OpenForms["mainMenu"];
            mhc.Show();
            this.Close();
        }
    }
}
