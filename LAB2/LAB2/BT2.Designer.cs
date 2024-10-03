namespace LAB2
{
    partial class BT2
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
            btnReadFile = new Button();
            ExitBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtFileName = new TextBox();
            txtFileSize = new TextBox();
            txtFilePath = new TextBox();
            txtLineCount = new TextBox();
            txtWordCount = new TextBox();
            txtCharacterCount = new TextBox();
            txtFileContent = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnReadFile
            // 
            btnReadFile.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadFile.Location = new Point(89, 12);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(314, 36);
            btnReadFile.TabIndex = 0;
            btnReadFile.Text = "Read From File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click_1;
            // 
            // ExitBtn
            // 
            ExitBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.Location = new Point(29, 393);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(314, 36);
            ExitBtn.TabIndex = 1;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 66);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 119);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 177);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 4;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 235);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 5;
            label4.Text = "Line Count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 289);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 6;
            label5.Text = "Word Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 344);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 7;
            label6.Text = "Character Count";
            label6.Click += label6_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(164, 66);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(179, 27);
            txtFileName.TabIndex = 8;
            // 
            // txtFileSize
            // 
            txtFileSize.Location = new Point(164, 119);
            txtFileSize.Name = "txtFileSize";
            txtFileSize.ReadOnly = true;
            txtFileSize.Size = new Size(179, 27);
            txtFileSize.TabIndex = 9;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(164, 177);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(179, 27);
            txtFilePath.TabIndex = 10;
            // 
            // txtLineCount
            // 
            txtLineCount.Location = new Point(164, 235);
            txtLineCount.Name = "txtLineCount";
            txtLineCount.ReadOnly = true;
            txtLineCount.Size = new Size(179, 27);
            txtLineCount.TabIndex = 11;
            // 
            // txtWordCount
            // 
            txtWordCount.Location = new Point(164, 289);
            txtWordCount.Name = "txtWordCount";
            txtWordCount.ReadOnly = true;
            txtWordCount.Size = new Size(179, 27);
            txtWordCount.TabIndex = 12;
            // 
            // txtCharacterCount
            // 
            txtCharacterCount.Location = new Point(164, 344);
            txtCharacterCount.Name = "txtCharacterCount";
            txtCharacterCount.ReadOnly = true;
            txtCharacterCount.Size = new Size(179, 27);
            txtCharacterCount.TabIndex = 13;
            // 
            // txtFileContent
            // 
            txtFileContent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFileContent.Location = new Point(413, 12);
            txtFileContent.Name = "txtFileContent";
            txtFileContent.ReadOnly = true;
            txtFileContent.Size = new Size(518, 417);
            txtFileContent.TabIndex = 14;
            txtFileContent.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(2, 2);
            button1.Name = "button1";
            button1.Size = new Size(81, 29);
            button1.TabIndex = 15;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BT2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 450);
            Controls.Add(button1);
            Controls.Add(txtFileContent);
            Controls.Add(txtCharacterCount);
            Controls.Add(txtWordCount);
            Controls.Add(txtLineCount);
            Controls.Add(txtFilePath);
            Controls.Add(txtFileSize);
            Controls.Add(txtFileName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ExitBtn);
            Controls.Add(btnReadFile);
            Name = "BT2";
            Text = "BT2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReadFile;
        private Button ExitBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFileName;
        private TextBox txtFileSize;
        private TextBox txtFilePath;
        private TextBox txtLineCount;
        private TextBox txtWordCount;
        private TextBox txtCharacterCount;
        private RichTextBox txtFileContent;
        private Button button1;
    }
}