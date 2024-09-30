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
            if (e.ColumnIndex == dataGridView1.Columns["Phai"].Index && e.RowIndex >= 0)
            {
                // Tạo combo box cho giới tính
                DataGridViewComboBoxCell genderCell = new DataGridViewComboBoxCell();
                genderCell.Items.Add("Male");
                genderCell.Items.Add("Female");
                dataGridView1[e.ColumnIndex, e.RowIndex] = genderCell;
            }

            if (e.RowIndex >= 0)
            {
                // Xác nhận xóa hàng
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex); // Xóa hàng
                }
            }
        }

        private void bt_back_Click_1(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Application.OpenForms["MainMenu"];
            mainMenu.Show();
            this.Close();
        }

        private void allname_TextChanged(object sender, EventArgs e)
        {

            string nameInput = allname.Text;

            // Kiểm tra nếu tên không hợp lệ (chỉ cho phép chữ cái và khoảng trắng)
            if (string.IsNullOrWhiteSpace(nameInput) ||
                System.Text.RegularExpressions.Regex.IsMatch(nameInput, @"[^a-zA-Z\sđĐêÊôÔáÁàÀảẢãÃạẠêÊíÍìÌỉỉĩĨịỊóÓòÒỏỌõÕọỌôÔúÚùÙủỦũŨưƯ]"))
            {
                // Hiển thị thông báo lỗi nếu tên không hợp lệ
                MessageBox.Show("Vui lòng nhập tên hợp lệ (chỉ bao gồm chữ cái và khoảng trắng).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allname.Text = string.Empty;  // Xóa nội dung không hợp lệ
                allname.Focus();  // Đưa con trỏ về TextBox
                return;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {// Lấy giá trị từ các trường nhập liệu
            string fullName = allname.Text.Trim();
            string gender = MorFM.SelectedItem?.ToString();
            string project1ScoreText = Pj1.Text.Trim();
            string project2ScoreText = Pj2.Text.Trim();
            string project3ScoreText = Pj5.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(project1ScoreText) || string.IsNullOrWhiteSpace(project2ScoreText) || string.IsNullOrWhiteSpace(project3ScoreText))
            {
                // Kiểm tra tính hợp lệ của dữ liệu
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuyển đổi điểm số từ chuỗi sang số và làm tròn đến 1 chữ số thập phân
            double project1Score = Math.Round(Convert.ToDouble(project1ScoreText), 1);
            double project2Score = Math.Round(Convert.ToDouble(project2ScoreText), 1);
            double project3Score = Math.Round(Convert.ToDouble(project3ScoreText), 1);

            // Tính điểm trung bình và làm tròn đến 1 chữ số thập phân
            double averageScore = Math.Round((project1Score + project2Score + project3Score) / 3, 1);

            // Xác định xếp loại
            string rank;
            if (averageScore >= 8 && project1Score >= 6.5 && project2Score >= 6.5 && project3Score >= 6.5)
                rank = "Very Good";
            else if (averageScore >= 6.5 && project1Score >= 5 && project2Score >= 5 && project3Score >= 5)
                rank = "Good";
            else if (averageScore >= 5 && project1Score >= 3.5 && project2Score >= 3.5 && project3Score >= 3.5)
                rank = "Average";
            else if (averageScore >= 3.5 && project1Score >= 2 && project2Score >= 2 && project3Score >= 2)
                rank = "Weak";
            else
                rank = "P";

            // Thêm dữ liệu vào DataGridView
            int rowIndex = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            row.Cells["Number"].Value = "TS" + (rowIndex + 1).ToString("D3"); // Tạo ID tự động
            row.Cells["name"].Value = fullName;
            row.Cells["Phai"].Value = gender;
            row.Cells["P1"].Value = project1Score;
            row.Cells["P2"].Value = project2Score;
            row.Cells["P3"].Value = project3Score;
            row.Cells["rank"].Value = rank; // Thêm xếp loại vào ô tương ứng

            // Xóa nội dung trong các trường nhập liệu sau khi lưu
            allname.Clear();
            MorFM.SelectedIndex = -1;
            Pj1.Clear();
            Pj2.Clear();
            Pj5.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả các hàng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa tất cả các hàng trong DataGridView
                dataGridView1.Rows.Clear();
            }
        }
    }

}