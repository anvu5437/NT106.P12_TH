﻿namespace LAB3
{
    partial class mainMenu
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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(158, 58);
            button1.Name = "button1";
            button1.Size = new Size(153, 59);
            button1.TabIndex = 0;
            button1.Text = "BT1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(47, 172);
            button3.Name = "button3";
            button3.Size = new Size(153, 59);
            button3.TabIndex = 2;
            button3.Text = "BT4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(259, 172);
            button4.Name = "button4";
            button4.Size = new Size(153, 59);
            button4.TabIndex = 3;
            button4.Text = "BT5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 322);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "mainMenu";
            Text = "mainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
    }
}