namespace LAB1
{
    partial class MainMenu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(116, 46);
            button1.TabIndex = 1;
            button1.Text = "Project 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OpenPrj1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(148, 214);
            button2.Name = "button2";
            button2.Size = new Size(116, 46);
            button2.TabIndex = 2;
            button2.Text = "Project 5";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OpenPrj5;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(290, 123);
            button3.Name = "button3";
            button3.Size = new Size(116, 46);
            button3.TabIndex = 3;
            button3.Text = "Project 4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OpenPrj4;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 123);
            button4.Name = "button4";
            button4.Size = new Size(116, 46);
            button4.TabIndex = 4;
            button4.Text = "Project 3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OpenPrj3;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(290, 12);
            button5.Name = "button5";
            button5.Size = new Size(116, 46);
            button5.TabIndex = 5;
            button5.Text = "Project 2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += OpenPrj2;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 272);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAB1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
