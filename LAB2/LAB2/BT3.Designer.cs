namespace LAB2
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
            btnRead = new Button();
            txtInput = new RichTextBox();
            txtOutput = new RichTextBox();
            btnWrite = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(33, 409);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(257, 34);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 41);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(306, 361);
            txtInput.TabIndex = 2;
            txtInput.Text = "";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(364, 12);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(306, 390);
            txtOutput.TabIndex = 3;
            txtOutput.Text = "";
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnWrite.Location = new Point(392, 409);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(257, 34);
            btnWrite.TabIndex = 4;
            btnWrite.Text = "Calculate";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 6);
            button1.Name = "button1";
            button1.Size = new Size(81, 29);
            button1.TabIndex = 16;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BT3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 450);
            Controls.Add(button1);
            Controls.Add(btnWrite);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnRead);
            Name = "BT3";
            Text = "BT3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private RichTextBox txtInput;
        private RichTextBox txtOutput;
        private Button btnWrite;
        private Button button1;
    }
}