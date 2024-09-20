namespace LAB1
{
    partial class Project5
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
            user = new GroupBox();
            GioiTinh = new ComboBox();
            diem3 = new Label();
            diem2 = new Label();
            diem1 = new Label();
            label2 = new Label();
            label1 = new Label();
            save = new TextBox();
            delete = new TextBox();
            textBox5 = new TextBox();
            mon2 = new TextBox();
            mon1 = new TextBox();
            hovaten = new TextBox();
            dataGridView1 = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Phai = new DataGridViewTextBoxColumn();
            P1 = new DataGridViewTextBoxColumn();
            P2 = new DataGridViewTextBoxColumn();
            P3 = new DataGridViewTextBoxColumn();
            xeploai = new DataGridViewComboBoxColumn();
            Del = new DataGridViewButtonColumn();
            user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // user
            // 
            user.Controls.Add(GioiTinh);
            user.Controls.Add(diem3);
            user.Controls.Add(diem2);
            user.Controls.Add(diem1);
            user.Controls.Add(label2);
            user.Controls.Add(label1);
            user.Controls.Add(save);
            user.Controls.Add(delete);
            user.Controls.Add(textBox5);
            user.Controls.Add(mon2);
            user.Controls.Add(mon1);
            user.Controls.Add(hovaten);
            user.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user.Location = new Point(18, 29);
            user.Name = "user";
            user.Size = new Size(764, 297);
            user.TabIndex = 0;
            user.TabStop = false;
            user.Text = "User";
            // 
            // GioiTinh
            // 
            GioiTinh.FormattingEnabled = true;
            GioiTinh.Items.AddRange(new object[] { "Male", "Female" });
            GioiTinh.Location = new Point(182, 117);
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Size = new Size(151, 36);
            GioiTinh.TabIndex = 12;
            // 
            // diem3
            // 
            diem3.AutoSize = true;
            diem3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diem3.Location = new Point(436, 205);
            diem3.Name = "diem3";
            diem3.Size = new Size(140, 20);
            diem3.TabIndex = 11;
            diem3.Text = "Score of project 3 :";
            // 
            // diem2
            // 
            diem2.AutoSize = true;
            diem2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diem2.Location = new Point(436, 133);
            diem2.Name = "diem2";
            diem2.Size = new Size(140, 20);
            diem2.TabIndex = 10;
            diem2.Text = "Score of project 2 :";
            // 
            // diem1
            // 
            diem1.AutoSize = true;
            diem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diem1.Location = new Point(436, 62);
            diem1.Name = "diem1";
            diem1.Size = new Size(140, 20);
            diem1.TabIndex = 9;
            diem1.Text = "Score of project 1 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 133);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 8;
            label2.Text = "Gender :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 62);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 7;
            label1.Text = "FULL NAME :";
            // 
            // save
            // 
            save.Location = new Point(6, 254);
            save.Name = "save";
            save.Size = new Size(83, 34);
            save.TabIndex = 6;
            save.Text = "Save";
            save.TextAlign = HorizontalAlignment.Center;
            // 
            // delete
            // 
            delete.Location = new Point(123, 254);
            delete.Name = "delete";
            delete.Size = new Size(78, 34);
            delete.TabIndex = 5;
            delete.Text = "Delete";
            delete.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(594, 191);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 34);
            textBox5.TabIndex = 4;
            // 
            // mon2
            // 
            mon2.Location = new Point(594, 119);
            mon2.Name = "mon2";
            mon2.Size = new Size(125, 34);
            mon2.TabIndex = 3;
            // 
            // mon1
            // 
            mon1.Location = new Point(594, 47);
            mon1.Name = "mon1";
            mon1.Size = new Size(125, 34);
            mon1.TabIndex = 2;
            // 
            // hovaten
            // 
            hovaten.Location = new Point(182, 47);
            hovaten.Name = "hovaten";
            hovaten.Size = new Size(125, 34);
            hovaten.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, name, Phai, P1, P2, P3, xeploai, Del });
            dataGridView1.Location = new Point(18, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1054, 229);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Number
            // 
            Number.HeaderText = "ID";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "Full Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // Phai
            // 
            Phai.HeaderText = "Gender";
            Phai.MinimumWidth = 6;
            Phai.Name = "Phai";
            Phai.Resizable = DataGridViewTriState.True;
            Phai.SortMode = DataGridViewColumnSortMode.NotSortable;
            Phai.Width = 125;
            // 
            // P1
            // 
            P1.HeaderText = "Project 1";
            P1.MinimumWidth = 6;
            P1.Name = "P1";
            P1.Width = 125;
            // 
            // P2
            // 
            P2.HeaderText = "Project 2";
            P2.MinimumWidth = 6;
            P2.Name = "P2";
            P2.Width = 125;
            // 
            // P3
            // 
            P3.HeaderText = "Project 3";
            P3.MinimumWidth = 6;
            P3.Name = "P3";
            P3.Width = 125;
            // 
            // xeploai
            // 
            xeploai.HeaderText = "Rank";
            xeploai.MinimumWidth = 6;
            xeploai.Name = "xeploai";
            xeploai.Width = 125;
            // 
            // Del
            // 
            Del.HeaderText = "Delete";
            Del.MinimumWidth = 6;
            Del.Name = "Del";
            Del.Resizable = DataGridViewTriState.True;
            Del.Text = "Dlt";
            Del.ToolTipText = "Del";
            Del.Width = 125;
            // 
            // Project5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 585);
            Controls.Add(dataGridView1);
            Controls.Add(user);
            Name = "Project5";
            Text = "Project5";
            user.ResumeLayout(false);
            user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox user;
        private Label diem3;
        private Label diem2;
        private Label diem1;
        private Label label2;
        private Label label1;
        private TextBox save;
        private TextBox delete;
        private TextBox textBox5;
        private TextBox mon2;
        private TextBox mon1;
        private TextBox gioitinh;
        private TextBox hovaten;
        private ComboBox GioiTinh;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Phai;
        private DataGridViewTextBoxColumn P1;
        private DataGridViewTextBoxColumn P2;
        private DataGridViewTextBoxColumn P3;
        private DataGridViewComboBoxColumn xeploai;
        private DataGridViewButtonColumn Del;
    }
}