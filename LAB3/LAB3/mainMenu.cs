using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BT1_Dashboard bt1 = new BT1_Dashboard();
            bt1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BT4_Dashboard bt1 = new BT4_Dashboard();
            bt1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BT5_Dashboard bt1 = new BT5_Dashboard();
            bt1.Show();
            this.Hide();
        }
    }
}
