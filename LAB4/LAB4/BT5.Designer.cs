namespace LAB4
{
    partial class BT5
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
            txtToken = new TextBox();
            btnGetUserInfo = new Button();
            txtResult = new TextBox();
            lblToken = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtToken
            // 
            txtToken.Location = new Point(12, 32);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(260, 27);
            txtToken.TabIndex = 0;
            // 
            // btnGetUserInfo
            // 
            btnGetUserInfo.Location = new Point(12, 58);
            btnGetUserInfo.Name = "btnGetUserInfo";
            btnGetUserInfo.Size = new Size(260, 30);
            btnGetUserInfo.TabIndex = 1;
            btnGetUserInfo.Text = "Lấy thông tin người dùng";
            btnGetUserInfo.UseVisualStyleBackColor = true;
            btnGetUserInfo.Click += btnGetUserInfo_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 108);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(260, 120);
            txtResult.TabIndex = 2;
            // 
            // lblToken
            // 
            lblToken.AutoSize = true;
            lblToken.Location = new Point(9, 16);
            lblToken.Name = "lblToken";
            lblToken.Size = new Size(122, 20);
            lblToken.TabIndex = 3;
            lblToken.Text = "Nhập JWT Token:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(9, 92);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(156, 20);
            lblResult.TabIndex = 4;
            lblResult.Text = "Thông tin người dùng:";
            // 
            // BT5
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(lblResult);
            Controls.Add(lblToken);
            Controls.Add(txtResult);
            Controls.Add(btnGetUserInfo);
            Controls.Add(txtToken);
            Name = "BT5";
            Text = "Thông tin người dùng";
            FormClosing += BT5_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnGetUserInfo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label lblResult;
    }
}
