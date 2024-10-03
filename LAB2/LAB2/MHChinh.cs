namespace LAB2
{
    public partial class MHChinh : Form
    {
        public MHChinh()
        {
            InitializeComponent();
        }

        private void bt1_bt_Click(object sender, EventArgs e)
        {
            BT1 bt1 = new BT1();
            bt1.Show();
            this.Hide();
        }

        private void bt2_bt_Click(object sender, EventArgs e)
        {
            BT2 bt2 = new BT2();
            bt2.Show();
            this.Hide();
        }

        private void bt3_bt_Click(object sender, EventArgs e)
        {
            BT3 bt3 = new BT3();
            bt3.Show();
            this.Hide();
        }

        private void bt4_bt_Click(object sender, EventArgs e)
        {
            BT4 bt4 = new BT4();
            bt4.Show();
            this.Hide();
        }

        private void bt5_bt_Click(object sender, EventArgs e)
        {
            BT5 bt5 = new BT5();
            bt5.Show();
            this.Hide();
        }
    }
}
