namespace LAB1
{
    partial class Project1
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
            lb_num1 = new Label();
            Title = new Label();
            lb_num2 = new Label();
            lb_num3 = new Label();
            tb_num1 = new TextBox();
            tb_num3 = new TextBox();
            tb_num2 = new TextBox();
            bt1_Find = new Button();
            bt_Delete = new Button();
            bt_Exit = new Button();
            Max = new Label();
            label2 = new Label();
            tb_max = new TextBox();
            tb_min = new TextBox();
            bt_back = new Button();
            SuspendLayout();
            // 
            // lb_num1
            // 
            lb_num1.Anchor = AnchorStyles.None;
            lb_num1.AutoSize = true;
            lb_num1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_num1.Location = new Point(12, 124);
            lb_num1.Name = "lb_num1";
            lb_num1.Size = new Size(108, 23);
            lb_num1.TabIndex = 0;
            lb_num1.Text = "1st number:";
            lb_num1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(12, 44);
            Title.Name = "Title";
            Title.Size = new Size(778, 41);
            Title.TabIndex = 1;
            Title.Text = "Find the largest and smallest numbers among three numbers";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_num2
            // 
            lb_num2.Anchor = AnchorStyles.None;
            lb_num2.AutoSize = true;
            lb_num2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_num2.Location = new Point(269, 124);
            lb_num2.Name = "lb_num2";
            lb_num2.Size = new Size(115, 23);
            lb_num2.TabIndex = 2;
            lb_num2.Text = "2nd number:";
            lb_num2.TextAlign = ContentAlignment.MiddleCenter;
            lb_num2.Click += label3_Click;
            // 
            // lb_num3
            // 
            lb_num3.Anchor = AnchorStyles.None;
            lb_num3.AutoSize = true;
            lb_num3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_num3.Location = new Point(547, 124);
            lb_num3.Name = "lb_num3";
            lb_num3.Size = new Size(112, 23);
            lb_num3.TabIndex = 3;
            lb_num3.Text = "3rd number:";
            lb_num3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_num1
            // 
            tb_num1.Anchor = AnchorStyles.None;
            tb_num1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_num1.Location = new Point(126, 119);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(125, 27);
            tb_num1.TabIndex = 4;
            tb_num1.TextChanged += textBox1_TextChanged;
            // 
            // tb_num3
            // 
            tb_num3.Anchor = AnchorStyles.None;
            tb_num3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_num3.Location = new Point(665, 120);
            tb_num3.Name = "tb_num3";
            tb_num3.Size = new Size(125, 27);
            tb_num3.TabIndex = 5;
            // 
            // tb_num2
            // 
            tb_num2.Anchor = AnchorStyles.None;
            tb_num2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_num2.Location = new Point(390, 119);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(125, 27);
            tb_num2.TabIndex = 6;
            tb_num2.TextChanged += tb_num2_TextChanged;
            // 
            // bt1_Find
            // 
            bt1_Find.Anchor = AnchorStyles.None;
            bt1_Find.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt1_Find.Location = new Point(148, 241);
            bt1_Find.Name = "bt1_Find";
            bt1_Find.Size = new Size(124, 47);
            bt1_Find.TabIndex = 7;
            bt1_Find.Text = "Find";
            bt1_Find.UseCompatibleTextRendering = true;
            bt1_Find.UseVisualStyleBackColor = true;
            bt1_Find.Click += bt1_Find_Click;
            // 
            // bt_Delete
            // 
            bt_Delete.Anchor = AnchorStyles.None;
            bt_Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Delete.Location = new Point(347, 241);
            bt_Delete.Name = "bt_Delete";
            bt_Delete.Size = new Size(124, 47);
            bt_Delete.TabIndex = 10;
            bt_Delete.Text = "Delete";
            bt_Delete.UseVisualStyleBackColor = true;
            bt_Delete.Click += bt_Delete_Click;
            // 
            // bt_Exit
            // 
            bt_Exit.Anchor = AnchorStyles.None;
            bt_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Exit.Location = new Point(557, 241);
            bt_Exit.Name = "bt_Exit";
            bt_Exit.Size = new Size(124, 47);
            bt_Exit.TabIndex = 11;
            bt_Exit.Text = "Exit";
            bt_Exit.UseVisualStyleBackColor = true;
            bt_Exit.Click += bt_Exit_Click;
            // 
            // Max
            // 
            Max.Anchor = AnchorStyles.None;
            Max.AutoSize = true;
            Max.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Max.Location = new Point(148, 364);
            Max.Name = "Max";
            Max.Size = new Size(58, 28);
            Max.TabIndex = 13;
            Max.Text = "Max:";
            Max.TextAlign = ContentAlignment.MiddleCenter;
            Max.Click += Max_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(488, 364);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 14;
            label2.Text = "Min:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // tb_max
            // 
            tb_max.Anchor = AnchorStyles.None;
            tb_max.Location = new Point(212, 364);
            tb_max.Name = "tb_max";
            tb_max.Size = new Size(125, 27);
            tb_max.TabIndex = 15;
            tb_max.TextChanged += textBox4_TextChanged;
            // 
            // tb_min
            // 
            tb_min.Anchor = AnchorStyles.None;
            tb_min.Location = new Point(548, 365);
            tb_min.Name = "tb_min";
            tb_min.Size = new Size(125, 27);
            tb_min.TabIndex = 16;
            tb_min.TextChanged += tb_min_TextChanged;
            // 
            // bt_back
            // 
            bt_back.Location = new Point(12, 12);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(48, 29);
            bt_back.TabIndex = 17;
            bt_back.Text = "Back\r\n\r\n";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += button1_Click;
            // 
            // Project1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 422);
            Controls.Add(bt_back);
            Controls.Add(tb_min);
            Controls.Add(tb_max);
            Controls.Add(label2);
            Controls.Add(Max);
            Controls.Add(bt_Exit);
            Controls.Add(bt_Delete);
            Controls.Add(bt1_Find);
            Controls.Add(tb_num2);
            Controls.Add(tb_num3);
            Controls.Add(tb_num1);
            Controls.Add(lb_num3);
            Controls.Add(lb_num2);
            Controls.Add(Title);
            Controls.Add(lb_num1);
            Name = "Project1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project1";
            Load += Project1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_num1;
        private Label Title;
        private Label lb_num2;
        private Label lb_num3;
        private TextBox tb_num1;
        private TextBox tb_num3;
        private TextBox tb_num2;
        private Button bt1_Find;
        private Button bt_Delete;
        private Button bt_Exit;
        private Label Max;
        private Label label2;
        private TextBox tb_max;
        private TextBox tb_min;
        private Button bt_back;
    }
}