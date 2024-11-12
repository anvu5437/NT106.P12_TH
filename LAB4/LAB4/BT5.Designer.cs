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
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnGetUserInfo = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(12, 32);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(260, 20);
            this.txtToken.TabIndex = 0;

            // 
            // btnGetUserInfo
            // 
            this.btnGetUserInfo.Location = new System.Drawing.Point(12, 58);
            this.btnGetUserInfo.Name = "btnGetUserInfo";
            this.btnGetUserInfo.Size = new System.Drawing.Size(260, 30);
            this.btnGetUserInfo.TabIndex = 1;
            this.btnGetUserInfo.Text = "Lấy thông tin người dùng";
            this.btnGetUserInfo.UseVisualStyleBackColor = true;
            this.btnGetUserInfo.Click += new System.EventHandler(this.btnGetUserInfo_Click);

            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 108);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(260, 120);
            this.txtResult.TabIndex = 2;
            this.txtResult.ReadOnly = true;

            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(9, 16);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(77, 13);
            this.lblToken.TabIndex = 3;
            this.lblToken.Text = "Nhập JWT Token:";

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 92);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(81, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Thông tin người dùng:";

            // 
            // BT5
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnGetUserInfo);
            this.Controls.Add(this.txtToken);
            this.Name = "BT5";
            this.Text = "Thông tin người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnGetUserInfo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label lblResult;
    }
}
