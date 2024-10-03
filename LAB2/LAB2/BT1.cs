using System;
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
    public partial class BT1 : Form
    {

        public BT1()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút "Đọc File"
        private void readFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"D:\"; // Thư mục khởi đầu
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Lọc file hiển thị
                openFileDialog.Title = "Chọn file để đọc";

                // Nếu người dùng chọn file và nhấn OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Đọc nội dung từ file đã chọn
                        using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                        {
                            string content = sr.ReadToEnd();
                            // Chuyển nội dung thành chữ in hoa
                            string upperContent = content.ToUpper();
                            // Hiển thị nội dung lên RichTextBox
                            richTextBox1.Text = upperContent;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
                    }
                }
            }
        }

        // Sự kiện khi nhấn nút "Ghi File"
        private void writeFile_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại nhập nội dung
            // Thay vì InputBox, chúng ta sẽ sử dụng một RichTextBox cho phép nhập nhiều dòng
            Form inputForm = new Form
            {
                Text = "Ghi File",
                Size = new System.Drawing.Size(400, 300)
            };

            RichTextBox inputTextBox = new RichTextBox
            {
                Dock = DockStyle.Fill,
                Multiline = true,
                Font = new System.Drawing.Font("Arial", 12),
                Text = "" // Để người dùng có thể nhập nội dung
            };

            Button submitButton = new Button
            {
                Text = "Ghi",
                Dock = DockStyle.Bottom
            };

            submitButton.Click += (s, args) =>
            {
                // Lấy nội dung từ RichTextBox
                string input = inputTextBox.Text;

                // Kiểm tra nếu người dùng đã nhập nội dung
                if (!string.IsNullOrEmpty(input))
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.InitialDirectory = @"D:\"; // Thư mục khởi đầu
                        saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Lọc file hiển thị
                        saveFileDialog.Title = "Lưu file";

                        // Nếu người dùng chọn nơi để lưu và nhấn OK
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                // Ghi nội dung đã nhập vào file đã chọn
                                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                                {
                                    sw.Write(input);
                                }

                                MessageBox.Show("Ghi file thành công!");
                                inputForm.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập nội dung nào để ghi.");
                }
            };

            inputForm.Controls.Add(inputTextBox);
            inputForm.Controls.Add(submitButton);
            inputForm.ShowDialog(); // Hiện hộp thoại nhập liệu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MHChinh mhc = (MHChinh)Application.OpenForms["MHChinh"];
            mhc.Show();
            this.Close();
        }
    }
}
