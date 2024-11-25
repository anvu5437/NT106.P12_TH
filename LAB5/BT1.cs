using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using System.Windows.Forms;

namespace LAB5
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //send button
        {
            try
            {
                // Lấy thông tin từ các textbox
                string fromEmail = textBox1.Text;
                string toEmail = textBox2.Text;
                string subject = textBox3.Text;
                string body = textBox4.Text;

                if (string.IsNullOrWhiteSpace(fromEmail) ||
                    string.IsNullOrWhiteSpace(toEmail) ||
                    string.IsNullOrWhiteSpace(subject) ||
                    string.IsNullOrWhiteSpace(body))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ các trường thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo email
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("", fromEmail));
                message.To.Add(new MailboxAddress("", toEmail));
                message.Subject = subject;
                message.Body = new TextPart("plain")
                {
                    Text = body
                };

                // Cấu hình SMTP client
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false); // SMTP server của Gmail
                    client.Authenticate("23520678@gm.uit.edu.vn", "rhix tfzj wkkk bhsg"); // Thay bằng email và app password của bạn
                    client.Send(message);
                    client.Disconnect(true);
                }

                MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi gửi email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
