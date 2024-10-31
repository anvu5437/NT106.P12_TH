using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace LAB4
{
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();

        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            string url = WebURL.Text; // TextBox chứa URL
            string filePath = Path.Combine(LocalURL.Text, "downloaded.html"); // Đảm bảo sử dụng tên file.
                                                                              // TextBox chứa đường dẫn lưu file

            try
            {
                // Khởi tạo WebClient
                using (WebClient myClient = new WebClient())
                {
                    // Download nội dung và lưu vào file HTML
                    myClient.DownloadFile(url, filePath);

                    // Đọc nội dung file HTML sau khi download
                    string htmlContent = File.ReadAllText(filePath, Encoding.UTF8);

                    // Hiển thị nội dung lên TextBox (multiline) hoặc WebBrowser
                    ContentBox.Text = htmlContent; // TextBox chứa nội dung trang web
                }

                MessageBox.Show("Download thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
