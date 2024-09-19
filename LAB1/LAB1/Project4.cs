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
    public partial class Project4 : Form
    {
        public Project4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBirthdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckZodiac_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy ngày sinh từ TextBox
                DateTime birthDate = DateTime.ParseExact(txtBirthdate.Text, "dd/MM/yyyy", null);

                // Lấy cung hoàng đạo
                string zodiacSign = GetZodiacSign(birthDate);

                // Hiển thị kết quả
                txtResult.Text = zodiacSign;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the right format (dd/MM/yyyy).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
        private string GetZodiacSign(DateTime birthDate)
        {
            int day = birthDate.Day;
            int month = birthDate.Month;

            switch (month)
            {
                case 1:
                    return (day >= 21) ? "Bảo Bình" : "Ma Kết";
                case 2:
                    return (day >= 20) ? "Song Ngư" : "Bảo Bình";
                case 3:
                    return (day >= 21) ? "Bạch Dương" : "Song Ngư";
                case 4:
                    return (day >= 21) ? "Kim Ngưu" : "Bạch Dương";
                case 5:
                    return (day >= 22) ? "Song Tử" : "Kim Ngưu";
                case 6:
                    return (day >= 22) ? "Cự Giải" : "Song Tử";
                case 7:
                    return (day >= 23) ? "Sư Tử" : "Cự Giải";
                case 8:
                    return (day >= 23) ? "Xử Nữ" : "Sư Tử";
                case 9:
                    return (day >= 24) ? "Thiên Bình" : "Xử Nữ";
                case 10:
                    return (day >= 24) ? "Thần Nông" : "Thiên Bình";
                case 11:
                    return (day >= 23) ? "Nhân Mã" : "Thần Nông";
                case 12:
                    return (day >= 22) ? "Ma Kết" : "Nhân Mã";
                default:
                    return "Unidentified!";
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            txtBirthdate.Clear();
            txtResult.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Application.OpenForms["MainMenu"];
            mainMenu.Show();
            this.Close();
        }
    }
}
