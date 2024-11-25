using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Windows.Forms;

namespace EmailClient
{
    public partial class FormSendEmail : Form
    {
        private string _fromEmail;
        private string _password;
        private SmtpClient _smtpClient;

        public FormSendEmail(string fromEmail, string password, SmtpClient smtpClient)
        {
            InitializeComponent();
            _fromEmail = fromEmail;
            _password = password;
            _smtpClient = smtpClient;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(_fromEmail, _fromEmail));
                message.To.Add(new MailboxAddress("", txtToEmail.Text));
                message.Subject = txtSubject.Text;
                message.Body = new TextPart("plain")
                {
                    Text = txtBody.Text
                };

                _smtpClient.Send(message);
                MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtAttachment.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
