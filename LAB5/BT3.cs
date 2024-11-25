using MailKit;
using MailKit.Net.Pop3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5
{
    public partial class BT3 : Form
    {
        public BT3()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
        }

        private void BT3_Load(object sender, EventArgs e)
        {

        }

        private void BT3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginBt_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text; // Email nhập vào
            string password = textBox1.Text; // Mật khẩu nhập vào

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập Email và Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kết nối tới server POP3
                using (var client = new Pop3Client())
                {
                    // Kết nối tới server Gmail
                    client.Connect("pop.gmail.com", 995, true); // Sử dụng SSL

                    // Xác thực tài khoản
                    client.Authenticate(email, password);

                    // Xóa các mục trong ListView trước khi load lại
                    listView1.Items.Clear();

                    // Giới hạn số email hiển thị (lấy 10 email)
                    int limit = Math.Min(10, client.Count);

                    for (int i = 0; i < limit; i++)
                    {
                        var message = client.GetMessage(i);

                        // Lấy thông tin email: Subject, From, Date
                        string subject = message.Subject ?? "(Không có tiêu đề)";
                        string from = message.From.ToString();
                        string date = message.Date.LocalDateTime.ToString("dd/MM/yyyy HH:mm:ss");

                        // Thêm email vào ListView
                        string[] row = { subject, from, date };
                        listView1.Items.Add(new ListViewItem(row));
                    }

                    // Ngắt kết nối
                    client.Disconnect(true);
                }

                MessageBox.Show("Lấy danh sách email thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy email: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
