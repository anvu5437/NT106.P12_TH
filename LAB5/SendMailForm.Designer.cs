namespace EmailClient
{
    partial class FormSendEmail
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtToEmail = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // txtToEmail
            this.txtToEmail.Location = new System.Drawing.Point(12, 12);
            this.txtToEmail.Name = "txtToEmail";
            this.txtToEmail.Size = new System.Drawing.Size(300, 22);
            this.txtToEmail.TabIndex = 0;
            this.txtToEmail.PlaceholderText = "Email người nhận";

            // txtSubject
            this.txtSubject.Location = new System.Drawing.Point(12, 50);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(400, 22);
            this.txtSubject.TabIndex = 1;
            this.txtSubject.PlaceholderText = "Chủ đề";

            // txtBody
            this.txtBody.Location = new System.Drawing.Point(12, 90);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(400, 150);
            this.txtBody.TabIndex = 2;
            this.txtBody.PlaceholderText = "Nội dung email";

            // btnSend
            this.btnSend.Location = new System.Drawing.Point(12, 310);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // btnBrowse
            this.btnBrowse.Location = new System.Drawing.Point(330, 260);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Chọn tệp";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            // txtAttachment
            this.txtAttachment.Location = new System.Drawing.Point(12, 260);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.Size = new System.Drawing.Size(300, 22);
            this.txtAttachment.TabIndex = 5;
            this.txtAttachment.PlaceholderText = "Tệp đính kèm";

            // FormSendEmail
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.txtAttachment);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtToEmail);
            this.Name = "FormSendEmail";
            this.Text = "Gửi Email";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtToEmail;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtAttachment;
    }
}
