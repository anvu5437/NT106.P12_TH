using System;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.IO;

namespace LAB5
{
    public partial class BT4 : Form
    {
        private ImapClient imapClient;
        private SmtpClient smtpClient;

        public BT4()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                imapClient = new ImapClient();
                imapClient.Connect(txtImap.Text, (int)numImapPort.Value, true);
                imapClient.Authenticate(txtEmail.Text, txtPassword.Text);

                smtpClient = new SmtpClient();
                smtpClient.Connect(txtSmtp.Text, (int)numSmtpPort.Value, true);
                smtpClient.Authenticate(txtEmail.Text, txtPassword.Text);

                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                LoadEmails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Thông báo");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                imapClient.Disconnect(true);
                smtpClient.Disconnect(true);
                dgvEmails.Rows.Clear();
                MessageBox.Show("Đăng xuất thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng xuất: " + ex.Message, "Thông báo");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmails();
        }

        private void LoadEmails()
        {
            try
            {
                dgvEmails.Rows.Clear();
                var inbox = imapClient.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                for (int i = inbox.Count - 1; i >= 0; i--)
                {
                    var message = inbox.GetMessage(i);
                    dgvEmails.Rows.Add(i, message.From.ToString(), message.Subject, message.Date.LocalDateTime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải email: " + ex.Message, "Thông báo");
            }
        }

        private void dgvEmails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = (int)dgvEmails.Rows[e.RowIndex].Cells[0].Value;
                var message = imapClient.Inbox.GetMessage(index);

                MessageBox.Show($"From: {message.From}\nTo: {message.To}\nSubject: {message.Subject}\n\n{message.TextBody}",
                                "Nội dung email");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc email: " + ex.Message, "Thông báo");
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            var sendMailForm = new SendMailForm(smtpClient, txtEmail.Text);
            sendMailForm.ShowDialog();
        }
    }
}
