using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{

    public partial class BT4 : Form
    {
        public BT4()
        {
            InitializeComponent();
        }
        private string filePath;
        private List<Student> students = new List<Student>(); // Danh sách học sinh
        private int currentIndex = 0; // Chỉ số học sinh hiện tại

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Next
        {
            if (students.Count > 0)
            {
                currentIndex = (currentIndex + 1) % students.Count; // Tăng chỉ số cho nút Next
                DisplayCurrentStudent();
            }
        }

        private void button1_Click(object sender, EventArgs e) //back
        {
            if (students.Count > 0)
            {
                currentIndex = (currentIndex - 1 + students.Count) % students.Count; // Lặp lại nếu đến đầu danh sách
                DisplayCurrentStudent();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bk_bt_Click(object sender, EventArgs e)
        {

        }

        private void id_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void wr_bt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn nơi lưu file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName; // Lưu đường dẫn vào biến toàn cục
                MessageBox.Show("Bạn đã chọn file: " + filePath);
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }
        // Thêm nội dung vào file
        private void add_bt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Vui lòng chọn file trước khi thêm nội dung.");
                return; // Dừng nếu chưa chọn file
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Ghi nội dung từ các TextBox vào file với định dạng có nhãn
                    writer.WriteLine("Họ và tên: " + name_tb.Text);
                    writer.WriteLine("MSSV: " + id_tb.Text);
                    writer.WriteLine("Điện thoại: " + phone_tb.Text);
                    writer.WriteLine("Điểm môn 1: " + crs1_tb.Text);
                    writer.WriteLine("Điểm môn 2: " + crs2_tb.Text);
                    writer.WriteLine("Điểm môn 3: " + crs3_tb.Text);
                    writer.WriteLine(); // Dòng trống để phân cách giữa các học sinh
                }

                MessageBox.Show("Nội dung đã được thêm vào file: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        // Xóa nội dụng ở các textbox nhập
        private void dl_bt_Click(object sender, EventArgs e)
        {
            name_tb.Text = string.Empty;
            id_tb.Text = string.Empty;
            phone_tb.Text = string.Empty;
            crs1_tb.Text = string.Empty;
            crs2_tb.Text = string.Empty;
            crs3_tb.Text = string.Empty;
        }

        private class Student
        {
            public string Name { get; set; }
            public string StudentId { get; set; }
            public string Phone { get; set; }
            public float Score1 { get; set; }
            public float Score2 { get; set; }
            public float Score3 { get; set; }
        }

        private void DisplayCurrentStudent()
        {
            if (students.Count > 0 && currentIndex >= 0 && currentIndex < students.Count)
            {
                Student student = students[currentIndex];
                name_rs_tb.Text = student.Name;
                ID_rs_tb.Text = student.StudentId;
                phone_rs_tb.Text = student.Phone;
                c1_rs_tb.Text = student.Score1.ToString();
                c2_rs_tb.Text = student.Score2.ToString();
                c3_rs_tb.Text = student.Score3.ToString();
                avr_rs_tb.Text = ((student.Score1 + student.Score2 + student.Score3) / 3).ToString("F2"); // Tính điểm trung bình
                pagenums_tb.Text = $"{currentIndex + 1}/{students.Count}"; // Hiển thị trang hiện tại
            }
        }
        private void rd_bt_Click(object sender, EventArgs e)
        {
            students.Clear();
            richTextBox1.Clear(); // Xóa nội dung trước đó trong RichTextBox

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Chọn một file văn bản";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Đọc nội dung từ file với mã hóa UTF-8
                        using (StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                if (line.StartsWith("Họ và tên: "))
                                {
                                    Student student = new Student();
                                    student.Name = line.Substring("Họ và tên: ".Length);
                                    student.StudentId = sr.ReadLine().Substring("MSSV: ".Length);
                                    student.Phone = sr.ReadLine().Substring("Điện thoại: ".Length);

                                    // Xử lý điểm môn 1, môn 2, môn 3 chấp nhận cả dấu phẩy và dấu chấm
                                    student.Score1 = float.Parse(sr.ReadLine().Substring("Điểm môn 1: ".Length).Replace('.', ','));
                                    student.Score2 = float.Parse(sr.ReadLine().Substring("Điểm môn 2: ".Length).Replace('.', ','));
                                    student.Score3 = float.Parse(sr.ReadLine().Substring("Điểm môn 3: ".Length).Replace('.', ','));

                                    students.Add(student);

                                    // Hiển thị thông tin học sinh trong RichTextBox
                                    richTextBox1.AppendText($"Họ và tên: {student.Name}\n");
                                    richTextBox1.AppendText($"MSSV: {student.StudentId}\n");
                                    richTextBox1.AppendText($"Điện thoại: {student.Phone}\n");
                                    richTextBox1.AppendText($"Điểm môn 1: {student.Score1}\n");
                                    richTextBox1.AppendText($"Điểm môn 2: {student.Score2}\n");
                                    richTextBox1.AppendText($"Điểm môn 3: {student.Score3}\n\n");
                                }
                            }
                        }

                        // Hiển thị học sinh đầu tiên (nếu có)
                        if (students.Count > 0)
                        {
                            currentIndex = 0; // Đặt chỉ mục về học sinh đầu tiên
                            DisplayCurrentStudent(); // Hiển thị thông tin học sinh lên các TextBox
                        }
                        else
                        {
                            MessageBox.Show("Không có học sinh nào trong file.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi đọc file: " + ex.Message);
                    }
                }
            }
        }




        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_rs_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MHChinh mhc = (MHChinh)Application.OpenForms["MHChinh"];
            mhc.Show();
            this.Close();
        }
    }
}
