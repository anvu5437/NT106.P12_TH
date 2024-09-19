namespace LAB1
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 77);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Insert A";
            label1.Click += InsA;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 145);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Insert B";
            label2.Click += InsB;
            // 
            // txtB
            // 
            txtB.Location = new Point(194, 145);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 2;
            txtB.TextChanged += txtB_TextChanged;
            // 
            // txtA
            // 
            txtA.Location = new Point(194, 77);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 3;
            txtA.TextChanged += txtA_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(484, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Click += comboBox1_SelectedIndexChanged;
            // 
            // CalBtn
            // 
            CalBtn.Location = new Point(100, 286);
            CalBtn.Name = "CalBtn";
            CalBtn.Size = new Size(135, 29);
            CalBtn.TabIndex = 5;
            CalBtn.Text = "Calculate";
            CalBtn.UseVisualStyleBackColor = true;
            CalBtn.Click += CalBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.Location = new Point(347, 286);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(135, 29);
            DelBtn.TabIndex = 6;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // ExtBtn
            // 
            ExtBtn.Location = new Point(590, 286);
            ExtBtn.Name = "ExtBtn";
            ExtBtn.Size = new Size(135, 29);
            ExtBtn.TabIndex = 7;
            ExtBtn.Text = "Exit";
            ExtBtn.UseVisualStyleBackColor = true;
            ExtBtn.Click += ExtBtn_Click;
            // 
            // OPDisplay
            // 
            OPDisplay.Location = new Point(100, 347);
            OPDisplay.Name = "OPDisplay";
            OPDisplay.Size = new Size(641, 94);
            OPDisplay.TabIndex = 8;
            OPDisplay.Text = "";
            OPDisplay.TextChanged += OPDisplay_TextChanged;
            // 
            // Project2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 450);
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
    }
}