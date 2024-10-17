namespace LAB3
{
    partial class BT4_Server
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.ListBox lstClients;

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
            this.btnListen = new System.Windows.Forms.Button();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(12, 12);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(12, 41);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(360, 307);
            this.txtLogs.TabIndex = 1;
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.Location = new System.Drawing.Point(378, 41);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(120, 307);
            this.lstClients.TabIndex = 2;
            // 
            // BT4_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 360);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.btnListen);
            this.Name = "BT4_Server";
            this.Text = "BT4_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
