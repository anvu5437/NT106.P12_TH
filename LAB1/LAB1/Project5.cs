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
    public partial class Project5 : Form
    {
        public Project5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "Phai";
            comboBoxColumn.HeaderText = "Gender";
            comboBoxColumn.Items.AddRange("Male", "Female");
            comboBoxColumn.Items.AddRange("Male", "Female");
            dataGridView1.Columns.Add(comboBoxColumn);
        }
        //private void bt_back_Click(object sender, EventArgs e)
        //{
           // MainMenu mainMenu = (MainMenu)Application.OpenForms["MainMenu"];
            //mainMenu.Show();
            //this.Close();
        //}

        private void bt_back_Click_1(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Application.OpenForms["MainMenu"];
            mainMenu.Show();
            this.Close();
        }
    }

}