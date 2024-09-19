using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1
{
    public partial class Project2 : Form
    {
        public Project2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Multiply Table");
            comboBox1.Items.Add("Factorial");
            comboBox1.Items.Add("Sum");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox
                int A = int.Parse(txtA.Text);
                int B = int.Parse(txtB.Text);

                // Kiểm tra người dùng đã chọn tính năng nào
                string selectedOption = comboBox1.SelectedItem.ToString();
                string result = "";

                if (selectedOption == "Multiply Table")
                {
                    // Tính bảng cửu chương B - A
                    int diff = A - B;
                    result = "Multiply Table of (B - A):\r\n" + GenerateMultiplicationTable(diff);
                }
                else if (selectedOption == "Factorial")
                {
                    // Tính giai thừa (A - B)!
                    int factorialResult = Factorial(A - B);
                    result = "Factorial of (A - B): " + factorialResult.ToString();
                }
                else if (selectedOption == "Sum")
                {
                    // Tính tổng S = A1 + A2 + ... + AB
                    int sum = CalculateSum(A, B);
                    result = "Sum S = A1 + A2 + ... + AB: " + sum.ToString();
                }
                else
                {
                    MessageBox.Show("Choose a Function");
                }

                // Hiển thị kết quả trong 1 TextBox
                OPDisplay.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            OPDisplay.Clear();
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InsB(object sender, EventArgs e)
        {

        }

        private void InsA(object sender, EventArgs e)
        {

        }
        private string GenerateMultiplicationTable(int number)
        {
            string result = "";
            for (int i = 1; i <= 10; i++)
            {
                result += $"{number} x {i} = {number * i}\r\n";
            }
            return result;
        }
        private int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Can't calc factorial for negetive num");
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        private int CalculateSum(int A, int B)
        {
            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                sum += i;
            }
            return sum;
        }

        private void OPDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
