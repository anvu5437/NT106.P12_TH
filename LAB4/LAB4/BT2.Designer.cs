namespace LAB4
{
    partial class BT2
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
            WebURL = new TextBox();
            LocalURL = new TextBox();
            ContentBox = new RichTextBox();
            DownloadBtn = new Button();
            SuspendLayout();
            // 
            // WebURL
            // 
            WebURL.Location = new Point(12, 12);
            WebURL.Name = "WebURL";
            WebURL.Size = new Size(511, 27);
            WebURL.TabIndex = 0;
            // 
            // LocalURL
            // 
            LocalURL.Location = new Point(12, 45);
            LocalURL.Name = "LocalURL";
            LocalURL.Size = new Size(511, 27);
            LocalURL.TabIndex = 1;
            // 
            // ContentBox
            // 
            ContentBox.Location = new Point(12, 97);
            ContentBox.Name = "ContentBox";
            ContentBox.Size = new Size(651, 341);
            ContentBox.TabIndex = 2;
            ContentBox.Text = "";
            // 
            // DownloadBtn
            // 
            DownloadBtn.Location = new Point(529, 12);
            DownloadBtn.Name = "DownloadBtn";
            DownloadBtn.Size = new Size(134, 29);
            DownloadBtn.TabIndex = 3;
            DownloadBtn.Text = "Download";
            DownloadBtn.UseVisualStyleBackColor = true;
            DownloadBtn.Click += DownloadBtn_Click;
            // 
            // BT2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 450);
            Controls.Add(DownloadBtn);
            Controls.Add(ContentBox);
            Controls.Add(LocalURL);
            Controls.Add(WebURL);
            Name = "BT2";
            Text = "BT2";
            FormClosing += BT2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox WebURL;
        private TextBox LocalURL;
        private RichTextBox ContentBox;
        private Button DownloadBtn;
    }
}