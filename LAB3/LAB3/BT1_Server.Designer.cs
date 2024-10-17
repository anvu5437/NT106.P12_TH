namespace LAB3
{
    partial class BT1_Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Portlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Porttxt = new System.Windows.Forms.TextBox();
            this.ListenBtn = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Portlbl
            // 
            this.Portlbl.AutoSize = true;
            this.Portlbl.Location = new System.Drawing.Point(71, 54);
            this.Portlbl.Name = "Portlbl";
            this.Portlbl.Size = new System.Drawing.Size(31, 16);
            this.Portlbl.TabIndex = 0;
            this.Portlbl.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recieved Message";
            // 
            // Porttxt
            // 
            this.Porttxt.Location = new System.Drawing.Point(134, 51);
            this.Porttxt.Name = "Porttxt";
            this.Porttxt.Size = new System.Drawing.Size(142, 22);
            this.Porttxt.TabIndex = 2;
            // 
            // ListenBtn
            // 
            this.ListenBtn.Location = new System.Drawing.Point(472, 51);
            this.ListenBtn.Name = "ListenBtn";
            this.ListenBtn.Size = new System.Drawing.Size(126, 23);
            this.ListenBtn.TabIndex = 4;
            this.ListenBtn.Text = "Listen";
            this.ListenBtn.UseVisualStyleBackColor = true;
            this.ListenBtn.Click += new System.EventHandler(this.ListenBtn_Click);
            // 
            // lstMessages
            // 
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 16;
            this.lstMessages.Location = new System.Drawing.Point(74, 130);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(660, 292);
            this.lstMessages.TabIndex = 5;
            // 
            // BT1_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.ListenBtn);
            this.Controls.Add(this.Porttxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Portlbl);
            this.Name = "BT1_Server";
            this.Text = "BT1_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Portlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Porttxt;
        private System.Windows.Forms.Button ListenBtn;
        private System.Windows.Forms.ListBox lstMessages;
    }
}