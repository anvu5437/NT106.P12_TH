namespace LAB1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void OpenPrj1(object sender, EventArgs e)
        {
            Project1 prj1 = new Project1();
            prj1.Show();
            this.Hide();
        }

        private void OpenPrj2(object sender, EventArgs e)
        {
            Project2 prj2 = new Project2();
            prj2.Show();
            this.Hide();
        }

        private void OpenPrj3(object sender, EventArgs e)
        {
            Project3 prj3 = new Project3();
            prj3.Show();
            this.Hide();
        }

        private void OpenPrj4(object sender, EventArgs e)
        {
            Project4 prj4 = new Project4();
            prj4.Show();
            this.Hide();
        }

        private void OpenPrj5(object sender, EventArgs e)
        {
            Project5 prj5 = new Project5();
            prj5.Show();
            this.Hide();
        }
    }
}
