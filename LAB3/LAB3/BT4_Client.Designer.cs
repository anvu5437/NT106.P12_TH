namespace LAB3
{
    partial class BT4_Client
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtRecipient; // Khai báo TextBox cho tên người nhận

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtMessage = new TextBox();
            txtChat = new TextBox();
            btnConnect = new Button();
            btnSend = new Button();
            txtRecipient = new TextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(391, 27);
            txtName.TabIndex = 0;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 109);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(401, 27);
            txtMessage.TabIndex = 3;
            // 
            // txtChat
            // 
            txtChat.Location = new Point(12, 156);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.Size = new Size(482, 152);
            txtChat.TabIndex = 5;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(419, 16);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(419, 113);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtRecipient
            // 
            txtRecipient.Location = new Point(12, 67);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(125, 27);
            txtRecipient.TabIndex = 2;
            // 
            // BT4_Client
            // 
            ClientSize = new Size(506, 320);
            Controls.Add(txtChat);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(txtRecipient);
            Controls.Add(btnConnect);
            Controls.Add(txtName);
            Name = "BT4_Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
