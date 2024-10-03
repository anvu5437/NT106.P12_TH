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
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReadFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Lấy thông tin tên file và đường dẫn
                string fileName = ofd.SafeFileName.ToString();
                string filePath = ofd.FileName.ToString();

                // Lấy kích thước file
                FileInfo fileInfo = new FileInfo(filePath);
                long fileSize = fileInfo.Length;

                // Đọc nội dung file
                string fileContent;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    fileContent = sr.ReadToEnd();
                }

                // Tính toán số dòng, số từ, số ký tự
                int lineCount = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).Length;
                int wordCount = fileContent.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                int characterCount = fileContent.Length;

                // Hiển thị các thông tin lên giao diện
                txtFileName.Text = fileName;
                txtFileSize.Text = fileSize.ToString() + " bytes";
                txtFilePath.Text = filePath;
                txtLineCount.Text = lineCount.ToString();
                txtWordCount.Text = wordCount.ToString();
                txtCharacterCount.Text = characterCount.ToString();
                txtFileContent.Text = fileContent;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MHChinh mhc = (MHChinh)Application.OpenForms["MHChinh"];
            mhc.Show();
            this.Close();
        }
    }
}
