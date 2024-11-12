namespace LAB4
{
    partial class BT1
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
            txt_Url = new TextBox();
            btn_Get = new Button();
            rtxt_HTML = new RichTextBox();
            SuspendLayout();
            // 
            // txt_Url
            // 
            txt_Url.Location = new Point(17, 22);
            txt_Url.Margin = new Padding(4, 5, 4, 5);
            txt_Url.Name = "txt_Url";
            txt_Url.Size = new Size(503, 27);
            txt_Url.TabIndex = 0;
            txt_Url.Text = "https://www.uit.edu.vn/";
            txt_Url.KeyDown += txt_Url_KeyDown;
            // 
            // btn_Get
            // 
            btn_Get.Location = new Point(529, 20);
            btn_Get.Margin = new Padding(4, 5, 4, 5);
            btn_Get.Name = "btn_Get";
            btn_Get.Size = new Size(100, 35);
            btn_Get.TabIndex = 1;
            btn_Get.Text = "GET";
            btn_Get.UseVisualStyleBackColor = true;
            btn_Get.Click += btn_Get_Click;
            // 
            // rtxt_HTML
            // 
            rtxt_HTML.BackColor = Color.White;
            rtxt_HTML.Location = new Point(17, 63);
            rtxt_HTML.Margin = new Padding(4, 5, 4, 5);
            rtxt_HTML.Name = "rtxt_HTML";
            rtxt_HTML.ReadOnly = true;
            rtxt_HTML.Size = new Size(611, 472);
            rtxt_HTML.TabIndex = 2;
            rtxt_HTML.Text = "";
            // 
            // BT1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 555);
            Controls.Add(rtxt_HTML);
            Controls.Add(btn_Get);
            Controls.Add(txt_Url);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "BT1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai01";
            FormClosing += BT1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.RichTextBox rtxt_HTML;
    }
}
