namespace LAB1
{
    partial class Project4
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
            label = new Label();
            txtBirthdate = new TextBox();
            txtResult = new TextBox();
            btnCalc = new Button();
            button1 = new Button();
            button2 = new Button();
            bt_back = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(36, 33);
            label.Name = "label";
            label.Size = new Size(237, 25);
            label.TabIndex = 0;
            label.Text = "Enter Birthdate(dd/mm/yy)";
            label.Click += label_Click;
            // 
            // txtBirthdate
            // 
            txtBirthdate.Location = new Point(275, 30);
            txtBirthdate.Name = "txtBirthdate";
            txtBirthdate.Size = new Size(165, 27);
            txtBirthdate.TabIndex = 1;
            txtBirthdate.TextChanged += txtBirthdate_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(275, 154);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(165, 27);
            txtResult.TabIndex = 2;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCalc.Location = new Point(293, 77);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(128, 59);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Check Zodiac";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCheckZodiac_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(72, 204);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 4;
            button1.Text = "Clear All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClearAll_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(312, 205);
            button2.Name = "button2";
            button2.Size = new Size(91, 34);
            button2.TabIndex = 5;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Exit_Click;
            // 
            // bt_back
            // 
            bt_back.Location = new Point(3, 1);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(48, 29);
            bt_back.TabIndex = 20;
            bt_back.Text = "Back\r\n\r\n";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += bt_back_Click;
            // 
            // Project4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 251);
            Controls.Add(bt_back);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCalc);
            Controls.Add(txtResult);
            Controls.Add(txtBirthdate);
            Controls.Add(label);
            Name = "Project4";
            Text = "Project4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox txtBirthdate;
        private TextBox txtResult;
        private Button btnCalc;
        private Button button1;
        private Button button2;
        private Button bt_back;
    }
}