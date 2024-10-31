namespace LAB4
{
    partial class BT3
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
            webView_bt3 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ULR_tb = new TextBox();
            go_bt = new Button();
            ViewSouce_bt = new Button();
            dlFile_bt = new Button();
            dlHTML_bt = new Button();
            ((System.ComponentModel.ISupportInitialize)webView_bt3).BeginInit();
            SuspendLayout();
            // 
            // webView_bt3
            // 
            webView_bt3.AllowExternalDrop = true;
            webView_bt3.CreationProperties = null;
            webView_bt3.DefaultBackgroundColor = Color.White;
            webView_bt3.Location = new Point(12, 80);
            webView_bt3.Name = "webView_bt3";
            webView_bt3.Size = new Size(1243, 511);
            webView_bt3.TabIndex = 0;
            webView_bt3.ZoomFactor = 1D;
            // 
            // ULR_tb
            // 
            ULR_tb.Location = new Point(95, 12);
            ULR_tb.Name = "ULR_tb";
            ULR_tb.Size = new Size(1050, 27);
            ULR_tb.TabIndex = 1;
            // 
            // go_bt
            // 
            go_bt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            go_bt.Location = new Point(12, 12);
            go_bt.Name = "go_bt";
            go_bt.Size = new Size(77, 27);
            go_bt.TabIndex = 2;
            go_bt.Text = "Go";
            go_bt.UseVisualStyleBackColor = true;
            go_bt.Click += go_bt_Click;
            // 
            // ViewSouce_bt
            // 
            ViewSouce_bt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewSouce_bt.Location = new Point(1151, 10);
            ViewSouce_bt.Name = "ViewSouce_bt";
            ViewSouce_bt.Size = new Size(104, 29);
            ViewSouce_bt.TabIndex = 3;
            ViewSouce_bt.Text = "View Source";
            ViewSouce_bt.UseVisualStyleBackColor = true;
            ViewSouce_bt.Click += ViewSouce_bt_Click;
            // 
            // dlFile_bt
            // 
            dlFile_bt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dlFile_bt.Location = new Point(953, 45);
            dlFile_bt.Name = "dlFile_bt";
            dlFile_bt.Size = new Size(148, 29);
            dlFile_bt.TabIndex = 4;
            dlFile_bt.Text = "Download file";
            dlFile_bt.UseVisualStyleBackColor = true;
            dlFile_bt.Click += dlFile_bt_Click;
            // 
            // dlHTML_bt
            // 
            dlHTML_bt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dlHTML_bt.Location = new Point(1107, 45);
            dlHTML_bt.Name = "dlHTML_bt";
            dlHTML_bt.Size = new Size(148, 29);
            dlHTML_bt.TabIndex = 5;
            dlHTML_bt.Text = "Download HTML";
            dlHTML_bt.UseVisualStyleBackColor = true;
            dlHTML_bt.Click += dlHTML_bt_Click;
            // 
            // BT3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 617);
            Controls.Add(dlHTML_bt);
            Controls.Add(dlFile_bt);
            Controls.Add(ViewSouce_bt);
            Controls.Add(go_bt);
            Controls.Add(ULR_tb);
            Controls.Add(webView_bt3);
            Name = "BT3";
            Text = "BT3";
            FormClosing += BT3_FormClosing;
            ((System.ComponentModel.ISupportInitialize)webView_bt3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView_bt3;
        private TextBox ULR_tb;
        private Button go_bt;
        private Button ViewSouce_bt;
        private Button dlFile_bt;
        private Button dlHTML_bt;
    }
}