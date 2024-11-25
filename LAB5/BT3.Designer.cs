namespace LAB5
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
            listView1 = new ListView();
            EmailColl = new ColumnHeader();
            FromColl = new ColumnHeader();
            TimeColl = new ColumnHeader();
            loginBt = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { EmailColl, FromColl, TimeColl });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 118);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(792, 289);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // EmailColl
            // 
            EmailColl.Text = "Email";
            EmailColl.Width = 375;
            // 
            // FromColl
            // 
            FromColl.Text = "Từ";
            FromColl.Width = 250;
            // 
            // TimeColl
            // 
            TimeColl.Text = "Thời gian";
            TimeColl.Width = 160;
            // 
            // loginBt
            // 
            loginBt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBt.Location = new Point(176, 83);
            loginBt.Name = "loginBt";
            loginBt.Size = new Size(94, 29);
            loginBt.TabIndex = 11;
            loginBt.Text = "Đăng nhập";
            loginBt.UseVisualStyleBackColor = true;
            loginBt.Click += loginBt_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 50);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 8;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Email:";
            // 
            // BT3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 419);
            Controls.Add(listView1);
            Controls.Add(loginBt);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BT3";
            Text = "BT3";
            FormClosing += BT3_FormClosing;
            Load += BT3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader EmailColl;
        private ColumnHeader FromColl;
        private ColumnHeader TimeColl;
        private Button loginBt;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}