using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BT6 bt6 = new BT6();
            bt6.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt1_btt_Click(object sender, EventArgs e)
        {
            BT1 bt1 = new BT1();
            bt1.Show();
            this.Hide();
        }

        private void bt2_btt_Click(object sender, EventArgs e)
        {
            BT2 bt2 = new BT2();
            bt2.Show();
            this.Hide();
        }

        private void bt3_btt_Click(object sender, EventArgs e)
        {
            BT3 bt3 = new BT3();
            bt3.Show();
            this.Hide();
        }

        private void bt4_btt_Click(object sender, EventArgs e)
        {
            BT4 bt4 = new BT4();
            bt4.Show();
            this.Hide();
        }

        private void bt5_btt_Click(object sender, EventArgs e)
        {
            BT5 bt5 = new BT5();
            bt5.Show();
            this.Hide();
        }
    }
}
