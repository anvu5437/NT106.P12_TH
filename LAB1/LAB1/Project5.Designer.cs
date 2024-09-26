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
            delete = new Button();
            save = new Button();
            MorFM = new ComboBox();
            point3 = new Label();
            point2 = new Label();
            point1 = new Label();
            gender = new Label();
            Fname = new Label();
            Pj5 = new TextBox();
            Pj2 = new TextBox();
            Pj1 = new TextBox();
            allname = new TextBox();
            dataGridView1 = new DataGridView();
            bt_back = new Button();
            Number = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Phai = new DataGridViewTextBoxColumn();
            P1 = new DataGridViewTextBoxColumn();
            P2 = new DataGridViewTextBoxColumn();
            P3 = new DataGridViewTextBoxColumn();
            rank = new DataGridViewTextBoxColumn();
            Del = new DataGridViewButtonColumn();
            user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // user
            // 
            user.Controls.Add(delete);
            user.Controls.Add(save);
            user.Controls.Add(MorFM);
            user.Controls.Add(point3);
            user.Controls.Add(point2);
            user.Controls.Add(point1);
            user.Controls.Add(gender);
            user.Controls.Add(Fname);
            user.Controls.Add(Pj5);
            user.Controls.Add(Pj2);
            user.Controls.Add(Pj1);
            user.Controls.Add(allname);
            user.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user.Location = new Point(18, 29);
            user.Name = "user";
            user.Size = new Size(764, 297);
            user.TabIndex = 0;
            user.TabStop = false;
            user.Text = "User";
            // 
            // delete
            // 
            delete.Location = new Point(106, 254);
            delete.Name = "delete";
            delete.Size = new Size(94, 37);
            delete.TabIndex = 22;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // save
            // 
            save.Location = new Point(6, 254);
            save.Name = "save";
            save.Size = new Size(94, 37);
            save.TabIndex = 13;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // MorFM
            // 
            MorFM.FormattingEnabled = true;
            MorFM.Items.AddRange(new object[] { "Male", "Female" });
            MorFM.Location = new Point(182, 117);
            MorFM.Name = "MorFM";
            MorFM.Size = new Size(151, 36);
            MorFM.TabIndex = 12;
            // 
            // point3
            // 
            point3.AutoSize = true;
            point3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point3.Location = new Point(436, 205);
            point3.Name = "point3";
            point3.Size = new Size(140, 20);
            point3.TabIndex = 11;
            point3.Text = "Score of project 3 :";
            // 
            // point2
            // 
            point2.AutoSize = true;
            point2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2.Location = new Point(436, 133);
            point2.Name = "point2";
            point2.Size = new Size(140, 20);
            point2.TabIndex = 10;
            point2.Text = "Score of project 2 :";
            // 
            // point1
            // 
            point1.AutoSize = true;
            point1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point1.Location = new Point(436, 62);
            point1.Name = "point1";
            point1.Size = new Size(140, 20);
            point1.TabIndex = 9;
            point1.Text = "Score of project 1 :";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender.Location = new Point(93, 133);
            gender.Name = "gender";
            gender.Size = new Size(68, 20);
            gender.TabIndex = 8;
            gender.Text = "Gender :";
            // 
            // Fname
            // 
            Fname.AutoSize = true;
            Fname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fname.Location = new Point(60, 62);
            Fname.Name = "Fname";
            Fname.Size = new Size(101, 20);
            Fname.TabIndex = 7;
            Fname.Text = "FULL NAME :";
            // 
            // Pj5
            // 
            Pj5.Location = new Point(594, 191);
            Pj5.Name = "Pj5";
            Pj5.Size = new Size(125, 34);
            Pj5.TabIndex = 4;
            // 
            // Pj2
            // 
            Pj2.Location = new Point(594, 119);
            Pj2.Name = "Pj2";
            Pj2.Size = new Size(125, 34);
            Pj2.TabIndex = 3;
            // 
            // Pj1
            // 
            Pj1.Location = new Point(594, 47);
            Pj1.Name = "Pj1";
            Pj1.Size = new Size(125, 34);
            Pj1.TabIndex = 2;
            // 
            // allname
            // 
            allname.Location = new Point(182, 47);
            allname.Name = "allname";
            allname.Size = new Size(125, 34);
            allname.TabIndex = 0;
            allname.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, name, Phai, P1, P2, P3, rank, Del });
            dataGridView1.Location = new Point(18, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1061, 229);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bt_back
            // 
            bt_back.Location = new Point(3, 0);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(48, 29);
            bt_back.TabIndex = 21;
            bt_back.Text = "Back\r\n\r\n";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += bt_back_Click_1;
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
            // rank
            // 
            rank.HeaderText = "Rank";
            rank.MinimumWidth = 6;
            rank.Name = "rank";
            rank.Resizable = DataGridViewTriState.True;
            rank.SortMode = DataGridViewColumnSortMode.NotSortable;
            rank.Width = 125;
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
            ClientSize = new Size(1166, 450);
            Controls.Add(dataGridView1);
            Controls.Add(user);
            Controls.Add(bt_back);
            Name = "Project5";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox textBox5;
        private TextBox mon2;
        private TextBox mon1;
        private TextBox gioitinh;
        private TextBox hovaten;
        private ComboBox GioiTinh;
        private DataGridView dataGridView1;

        private Button bt_back;
        private Label gender;
        private Label Fname;
        private TextBox allname;
        private ComboBox MorFM;
        private Label point3;
        private Label point2;
        private Label point1;
        private TextBox Pj5;
        private TextBox Pj2;
        private TextBox Pj1;
        private Button delete;
        private Button save;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Phai;
        private DataGridViewTextBoxColumn P1;
        private DataGridViewTextBoxColumn P2;
        private DataGridViewTextBoxColumn P3;
        private DataGridViewTextBoxColumn rank;
        private DataGridViewButtonColumn Del;
    }
}