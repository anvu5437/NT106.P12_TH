﻿namespace LAB1
{
    partial class Project2
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
            label1 = new Label();
            label2 = new Label();
            txtB = new TextBox();
            txtA = new TextBox();
            comboBox1 = new ComboBox();
            CalBtn = new Button();
            DelBtn = new Button();
            ExtBtn = new Button();
            OPDisplay = new RichTextBox();
            bt_back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 51);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Insert A";
            label1.Click += InsA;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 108);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Insert B";
            label2.Click += InsB;
            // 
            // txtB
            // 
            txtB.Anchor = AnchorStyles.None;
            txtB.Location = new Point(165, 106);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 2;
            txtB.TextChanged += txtB_TextChanged;
            // 
            // txtA
            // 
            txtA.Anchor = AnchorStyles.None;
            txtA.Location = new Point(165, 49);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 3;
            txtA.TextChanged += txtA_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(58, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Click += comboBox1_SelectedIndexChanged;
            // 
            // CalBtn
            // 
            CalBtn.Anchor = AnchorStyles.None;
            CalBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalBtn.Location = new Point(58, 251);
            CalBtn.Name = "CalBtn";
            CalBtn.Size = new Size(135, 29);
            CalBtn.TabIndex = 5;
            CalBtn.Text = "Calculate";
            CalBtn.UseVisualStyleBackColor = true;
            CalBtn.Click += CalBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.Anchor = AnchorStyles.None;
            DelBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelBtn.Location = new Point(58, 297);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(135, 29);
            DelBtn.TabIndex = 6;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // ExtBtn
            // 
            ExtBtn.Anchor = AnchorStyles.None;
            ExtBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExtBtn.Location = new Point(57, 344);
            ExtBtn.Name = "ExtBtn";
            ExtBtn.Size = new Size(135, 29);
            ExtBtn.TabIndex = 7;
            ExtBtn.Text = "Exit";
            ExtBtn.UseVisualStyleBackColor = true;
            ExtBtn.Click += ExtBtn_Click;
            // 
            // OPDisplay
            // 
            OPDisplay.Anchor = AnchorStyles.None;
            OPDisplay.Location = new Point(456, 12);
            OPDisplay.Name = "OPDisplay";
            OPDisplay.Size = new Size(307, 426);
            OPDisplay.TabIndex = 8;
            OPDisplay.Text = "";
            OPDisplay.TextChanged += OPDisplay_TextChanged;
            // 
            // bt_back
            // 
            bt_back.Location = new Point(12, 11);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(48, 29);
            bt_back.TabIndex = 18;
            bt_back.Text = "Back\r\n\r\n";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += button1_Click;
            // 
            // Project2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(bt_back);
            Controls.Add(OPDisplay);
            Controls.Add(ExtBtn);
            Controls.Add(DelBtn);
            Controls.Add(CalBtn);
            Controls.Add(comboBox1);
            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Project2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtB;
        private TextBox txtA;
        private ComboBox comboBox1;
        private Button CalBtn;
        private Button DelBtn;
        private Button ExtBtn;
        private RichTextBox OPDisplay;
        private Button bt_back;
    }
}