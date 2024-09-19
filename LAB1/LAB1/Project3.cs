using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Project3 : Form
    {
        public Project3()
        {
            InitializeComponent();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Application.OpenForms["MainMenu"];
            mainMenu.Show();
            this.Close();
        }
    }
}
