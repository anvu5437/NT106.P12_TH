using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit;
using System;
using System.Windows.Forms;

namespace EmailClient
{
    public partial class BT4 : Form
    {
        private ImapClient _imapClient;
        private SmtpClient _smtpClient;

        public BT4()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối IMAP
                _imapClient = new ImapClient();
                _imapClient.Connect(txtIMAP.Text, int.Parse(txtIMAPPort.Text), true);
                _imapClient.Authenticate(txtEmail.Text, txtPassword.Text);

                // Kết nối SMTP
                _smtpClient = new SmtpClient();
                _smtpClient.Connect("smtp.gmail.com", 465, true); // SSL
                _smtpClient.Authenticate(txtEmail.Text, txtPassword.Text);

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải danh sách email
                LoadEmails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmails()
        {
            try
            {
                var inbox = _imapClient.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                dgvEmails.Rows.Clear();

                for (int i = inbox.Count - 1; i >= Math.Max(inbox.Count - 10, 0); i--)
                {
                    var message = inbox.GetMessage(i);
                    dgvEmails.Rows.Add(i + 1, message.From.ToString(), message.Subject, message.Date.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            // Hiển thị form gửi email
            var sendMailForm = new FormSendEmail(txtEmail.Text, txtPassword.Text, _smtpClient);
            sendMailForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (_imapClient != null && _imapClient.IsConnected)
                {
                    _imapClient.Disconnect(true);
                }

                if (_smtpClient != null && _smtpClient.IsConnected)
                {
                    _smtpClient.Disconnect(true);
                }

                MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Đăng xuất thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
