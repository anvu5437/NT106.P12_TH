using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LAB1
{
    public partial class Project1 : Form
    {
        public Project1()
        {
            InitializeComponent();
        }
        float num1, num2, num3;
        float max, min;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Max_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            tb_num1.Text = string.Empty;
            tb_num2.Text = string.Empty;
            tb_num3.Text = string.Empty;
            tb_max.Text = string.Empty;
            tb_min.Text = string.Empty;
        }

        private void tb_num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Find_Click(object sender, EventArgs e)
        {
            bool isNum1Valid = float.TryParse(tb_num1.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out num1);
            bool isNum2Valid = float.TryParse(tb_num2.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out num2);
            bool isNum3Valid = float.TryParse(tb_num3.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out num3);

            if (isNum1Valid && isNum2Valid && isNum3Valid)
            {
                max = Math.Max(num1, Math.Max(num2, num3));
                min = Math.Min(num1, Math.Min(num2, num3));
                tb_max.Text = max.ToString(CultureInfo.InvariantCulture);
                tb_min.Text = min.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ba số thực hợp lệ.");
                tb_max.Text = string.Empty;
                tb_min.Text = string.Empty;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Application.OpenForms["MainMenu"];
            mainMenu.Show();
            this.Close();
        }
    }
}
