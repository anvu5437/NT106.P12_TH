using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace LAB5
{
    public partial class SendMailForm : Form
    {
        private SmtpClient smtpClient;
        private string fromEmail;

        public SendMailForm(SmtpClient smtpClient, string fromEmail)
        {
            InitializeComponent();
            this.smtpClient = smtpClient;
            this.fromEmail = fromEmail;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Sender Name", fromEmail));
                message.To.Add(new MailboxAddress("Recipient Name", txtTo.Text));

                message.Subject = txtSubject.Text;

                var bodyBuilder = new BodyBuilder { TextBody = txtBody.Text };
                if (!string.IsNullOrEmpty(attachmentPath))
                {
                    bodyBuilder.Attachments.Add(attachmentPath);
                }
                message.Body = bodyBuilder.ToMessageBody();

                smtpClient.Send(message);
                MessageBox.Show("Gửi mail thành công!", "Thông báo");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi mail: " + ex.Message, "Thông báo");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                attachmentPath = openFileDialog.FileName;
                lblAttachment.Text = "File: " + Path.GetFileName(attachmentPath);
            }
        }
    }
}
