namespace LAB2
{
    partial class BT1
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
            readFile = new Button();
            writeFile = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // readFile
            // 
            readFile.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            readFile.Location = new Point(23, 42);
            readFile.Name = "readFile";
            readFile.Size = new Size(270, 119);
            readFile.TabIndex = 0;
            readFile.Text = "Đọc File";
            readFile.UseVisualStyleBackColor = true;
            // 
            // writeFile
            // 
            writeFile.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            writeFile.Location = new Point(23, 204);
            writeFile.Name = "writeFile";
            writeFile.Size = new Size(270, 120);
            writeFile.TabIndex = 1;
            writeFile.Text = "Ghi File";
            writeFile.UseCompatibleTextRendering = true;
            writeFile.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(369, 42);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(419, 396);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            this.writeFile.Click += new System.EventHandler(this.writeFile_Click);
            this.readFile.Click += new System.EventHandler(this.readFile_Click);
            // 
            // BT1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(writeFile);
            Controls.Add(readFile);
            Name = "BT1";
            Text = "BT1";
            ResumeLayout(false);
        }

        #endregion

        private Button readFile;
        private Button writeFile;
        private RichTextBox richTextBox1;
    }
}