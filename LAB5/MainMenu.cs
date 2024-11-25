using EmailClient;

namespace LAB5
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
