using System;
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

        private void Project3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Sự kiện click của nút Pronouce
        private void button1_Click(object sender, EventArgs e)
        {
            string numberText = Number.Text;
            if (long.TryParse(numberText, out long number) && number >= 0 && number <= 999999999999)
            {
                TextNum.Text = NumberToWords(number);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên từ 0 đến 999,999,999,999.");
            }
        }

        // Hàm chuyển đổi số thành chữ
        private string NumberToWords(long number)
        {
            if (number == 0) return "Không";

            string[] units = { "", "nghìn", "triệu", "tỷ" };
            string[] ones = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string[] teens = { "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
            string[] tens = { "", "Mười", "Hai mươi", "Ba mươi", "Bốn mươi", "Năm mươi", "Sáu mươi", "Bảy mươi", "Tám mươi", "Chín mươi" };

            string words = "";
            int groupIndex = 0;

            while (number > 0)
            {
                int part = (int)(number % 1000);
                if (part > 0)
                {
                    words = ConvertPart(part, ones, teens, tens) + " " + units[groupIndex] + " " + words;
                }
                number /= 1000;
                groupIndex++;
            }

            return words.Trim();
        }

        // Hàm chuyển đổi mỗi nhóm 3 chữ số
        private string ConvertPart(int number, string[] ones, string[] teens, string[] tens)
        {
            string words = "";

            if (number / 100 > 0)
            {
                words += ones[number / 100] + " trăm ";
                number %= 100;
            }

            if (number / 10 > 1)
            {
                words += tens[number / 10];
                if (number % 10 > 0)
                {
                    words += " " + ones[number % 10];
                }
            }
            else if (number / 10 == 1)
            {
                words += teens[number % 10];
            }
            else if (number % 10 > 0)
            {
                words += ones[number % 10];
            }

            return words.Trim();
        }

        private void lb_pronouce_Click(object sender, EventArgs e)
        {

        }
    }
}
