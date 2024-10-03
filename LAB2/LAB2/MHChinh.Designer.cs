namespace LAB2
{
    partial class MHChinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt1_bt = new Button();
            bt2_bt = new Button();
            bt3_bt = new Button();
            bt5_bt = new Button();
            bt4_bt = new Button();
            luuy = new Label();
            SuspendLayout();
            // 
            // bt1_bt
            // 
            bt1_bt.Location = new Point(138, 28);
            bt1_bt.Name = "bt1_bt";
            bt1_bt.Size = new Size(111, 53);
            bt1_bt.TabIndex = 0;
            bt1_bt.Text = "BT1";
            bt1_bt.UseVisualStyleBackColor = true;
            bt1_bt.Click += bt1_bt_Click;
            // 
            // bt2_bt
            // 
            bt2_bt.Location = new Point(28, 113);
            bt2_bt.Name = "bt2_bt";
            bt2_bt.Size = new Size(111, 53);
            bt2_bt.TabIndex = 1;
            bt2_bt.Text = "BT2";
            bt2_bt.UseVisualStyleBackColor = true;
            bt2_bt.Click += bt2_bt_Click;
            // 
            // bt3_bt
            // 
            bt3_bt.Location = new Point(251, 113);
            bt3_bt.Name = "bt3_bt";
            bt3_bt.Size = new Size(111, 53);
            bt3_bt.TabIndex = 2;
            bt3_bt.Text = "BT3";
            bt3_bt.UseVisualStyleBackColor = true;
            bt3_bt.Click += bt3_bt_Click;
            // 
            // bt5_bt
            // 
            bt5_bt.Location = new Point(251, 210);
            bt5_bt.Name = "bt5_bt";
            bt5_bt.Size = new Size(111, 53);
            bt5_bt.TabIndex = 4;
            bt5_bt.Text = "BT5";
            bt5_bt.UseVisualStyleBackColor = true;
            bt5_bt.Click += bt5_bt_Click;
            // 
            // bt4_bt
            // 
            bt4_bt.Location = new Point(28, 210);
            bt4_bt.Name = "bt4_bt";
            bt4_bt.Size = new Size(111, 53);
            bt4_bt.TabIndex = 3;
            bt4_bt.Text = "BT4";
            bt4_bt.UseVisualStyleBackColor = true;
            bt4_bt.Click += bt4_bt_Click;
            // 
            // luuy
            // 
            luuy.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            luuy.Location = new Point(4, 279);
            luuy.Name = "luuy";
            luuy.Size = new Size(382, 42);
            luuy.TabIndex = 5;
            luuy.Text = "Lưu ý: Vui lòng quay lại nàm hình chính rồi tắt chương trình";
            luuy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MHChinh
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 330);
            Controls.Add(luuy);
            Controls.Add(bt5_bt);
            Controls.Add(bt4_bt);
            Controls.Add(bt3_bt);
            Controls.Add(bt2_bt);
            Controls.Add(bt1_bt);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MHChinh";
            Text = "Màn hình chính ";
            ResumeLayout(false);
        }

        #endregion

        private Button bt1_bt;
        private Button bt2_bt;
        private Button bt3_bt;
        private Button bt5_bt;
        private Button bt4_bt;
        private Label luuy;
    }
}
