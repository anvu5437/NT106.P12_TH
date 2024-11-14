namespace LAB4
{
    partial class MainMenu
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
            bt6_btt = new Button();
            bt5_btt = new Button();
            bt4_btt = new Button();
            bt2_btt = new Button();
            bt1_btt = new Button();
            bt3_btt = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bt6_btt
            // 
            bt6_btt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt6_btt.Location = new Point(195, 282);
            bt6_btt.Name = "bt6_btt";
            bt6_btt.Size = new Size(120, 45);
            bt6_btt.TabIndex = 5;
            bt6_btt.Text = "BT6";
            bt6_btt.UseVisualStyleBackColor = true;
            bt6_btt.Click += button6_Click;
            // 
            // bt5_btt
            // 
            bt5_btt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt5_btt.Location = new Point(195, 177);
            bt5_btt.Name = "bt5_btt";
            bt5_btt.Size = new Size(120, 45);
            bt5_btt.TabIndex = 6;
            bt5_btt.Text = "BT5";
            bt5_btt.UseVisualStyleBackColor = true;
            bt5_btt.Click += bt5_btt_Click;
            // 
            // bt4_btt
            // 
            bt4_btt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt4_btt.Location = new Point(195, 75);
            bt4_btt.Name = "bt4_btt";
            bt4_btt.Size = new Size(120, 45);
            bt4_btt.TabIndex = 7;
            bt4_btt.Text = "BT4";
            bt4_btt.UseVisualStyleBackColor = true;
            bt4_btt.Click += bt4_btt_Click;
            // 
            // bt2_btt
            // 
            bt2_btt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt2_btt.Location = new Point(12, 177);
            bt2_btt.Name = "bt2_btt";
            bt2_btt.Size = new Size(120, 45);
            bt2_btt.TabIndex = 8;
            bt2_btt.Text = "BT2";
            bt2_btt.UseVisualStyleBackColor = true;
            bt2_btt.Click += bt2_btt_Click;
            // 
            // bt1_btt
            // 
            bt1_btt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt1_btt.Location = new Point(12, 75);
            bt1_btt.Name = "bt1_btt";
            bt1_btt.Size = new Size(120, 45);
            bt1_btt.TabIndex = 9;
            bt1_btt.Text = "BT1";
            bt1_btt.UseVisualStyleBackColor = true;
            bt1_btt.Click += bt1_btt_Click;
            // 
            // bt3_btt
            // 
            bt3_btt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt3_btt.Location = new Point(12, 282);
            bt3_btt.Name = "bt3_btt";
            bt3_btt.Size = new Size(120, 45);
            bt3_btt.TabIndex = 10;
            bt3_btt.Text = "BT3";
            bt3_btt.UseVisualStyleBackColor = true;
            bt3_btt.Click += bt3_btt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 24);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 11;
            label1.Text = "LAB4";
            label1.Click += label1_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 368);
            Controls.Add(label1);
            Controls.Add(bt3_btt);
            Controls.Add(bt1_btt);
            Controls.Add(bt2_btt);
            Controls.Add(bt4_btt);
            Controls.Add(bt5_btt);
            Controls.Add(bt6_btt);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt6_btt;
        private Button bt5_btt;
        private Button bt4_btt;
        private Button bt2_btt;
        private Button bt1_btt;
        private Button bt3_btt;
        private Label label1;
    }
}