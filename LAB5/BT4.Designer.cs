namespace LAB5
{
    partial class BT4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtImap;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.NumericUpDown numImapPort;
        private System.Windows.Forms.NumericUpDown numSmtpPort;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvEmails;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnRefresh;

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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtImap = new System.Windows.Forms.TextBox();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.numImapPort = new System.Windows.Forms.NumericUpDown();
            this.numSmtpPort = new System.Windows.Forms.NumericUpDown();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvEmails = new System.Windows.Forms.DataGridView();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numImapPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSmtpPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            // 
            // txtImap
            // 
            this.txtImap.Location = new System.Drawing.Point(230, 12);
            this.txtImap.Name = "txtImap";
            this.txtImap.Size = new System.Drawing.Size(200, 20);
            this.txtImap.TabIndex = 2;
            this.txtImap.Text = "imap.gmail.com";
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(230, 38);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(200, 20);
            this.txtSmtp.TabIndex = 3;
            this.txtSmtp.Text = "smtp.gmail.com";
            // 
            // numImapPort
            // 
            this.numImapPort.Location = new System.Drawing.Point(450, 12);
            this.numImapPort.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.numImapPort.Name = "numImapPort";
            this.numImapPort.Size = new System.Drawing.Size(60, 20);
            this.numImapPort.TabIndex = 4;
            this.numImapPort.Value = new decimal(new int[] { 993, 0, 0, 0 });
            // 
            // numSmtpPort
            // 
            this.numSmtpPort.Location = new System.Drawing.Point(450, 38);
            this.numSmtpPort.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.numSmtpPort.Name = "numSmtpPort";
            this.numSmtpPort.Size = new System.Drawing.Size(60, 20);
            this.numSmtpPort.TabIndex = 5;
            this.numSmtpPort.Value = new decimal(new int[] { 465, 0, 0, 0 });
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(530, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(530, 38);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvEmails
            // 
            this.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmails.Location = new System.Drawing.Point(12, 80);
            this.dgvEmails.Name = "dgvEmails";
            this.dgvEmails.Size = new System.Drawing.Size(760, 300);
            this.dgvEmails.TabIndex = 8;
            this.dgvEmails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmails_CellDoubleClick);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(620, 12);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendMail.TabIndex = 9;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(620, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.dgvEmails);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.numSmtpPort);
            this.Controls.Add(this.numImapPort);
            this.Controls.Add(this.txtSmtp);
            this.Controls.Add(this.txtImap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Name = "Form1";
            this.Text = "Email Client";
            ((System.ComponentModel.ISupportInitialize)(this.numImapPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSmtpPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
