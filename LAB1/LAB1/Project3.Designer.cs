namespace LAB1
{
    partial class Project3
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
            components = new System.ComponentModel.Container();
            bt_back = new Button();
            lb_inputnum = new Label();
            lb_pronouce = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Number = new TextBox();
            TextNum = new TextBox();
            pronc = new Button();
            SuspendLayout();
            // 
            // bt_back
            // 
            bt_back.Location = new Point(12, 12);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(48, 29);
            bt_back.TabIndex = 19;
            bt_back.Text = "Back\r\n\r\n";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += bt_back_Click;
            // 
            // lb_inputnum
            // 
            lb_inputnum.Anchor = AnchorStyles.None;
            lb_inputnum.AutoSize = true;
            lb_inputnum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_inputnum.Location = new Point(12, 101);
            lb_inputnum.Name = "lb_inputnum";
            lb_inputnum.Size = new Size(147, 28);
            lb_inputnum.TabIndex = 20;
            lb_inputnum.Text = "Enter number:";
            // 
            // lb_pronouce
            // 
            lb_pronouce.Anchor = AnchorStyles.None;
            lb_pronouce.AutoSize = true;
            lb_pronouce.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_pronouce.Location = new Point(12, 290);
            lb_pronouce.Name = "lb_pronouce";
            lb_pronouce.Size = new Size(204, 28);
            lb_pronouce.TabIndex = 21;
            lb_pronouce.Text = "Pronounce number: ";
            lb_pronouce.TextAlign = ContentAlignment.MiddleCenter;
            lb_pronouce.Click += lb_pronouce_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Number
            // 
            Number.Anchor = AnchorStyles.None;
            Number.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Number.Location = new Point(165, 103);
            Number.Name = "Number";
            Number.Size = new Size(287, 30);
            Number.TabIndex = 23;
            Number.TextChanged += textBox1_TextChanged;
            // 
            // TextNum
            // 
            TextNum.Anchor = AnchorStyles.None;
            TextNum.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextNum.Location = new Point(222, 292);
            TextNum.Multiline = true;
            TextNum.Name = "TextNum";
            TextNum.ShortcutsEnabled = false;
            TextNum.Size = new Size(557, 55);
            TextNum.TabIndex = 24;
            TextNum.TabStop = false;
            TextNum.TextAlign = HorizontalAlignment.Center;
            TextNum.TextChanged += textBox2_TextChanged;
            // 
            // pronc
            // 
            pronc.Anchor = AnchorStyles.None;
            pronc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pronc.Location = new Point(241, 164);
            pronc.Name = "pronc";
            pronc.Size = new Size(116, 34);
            pronc.TabIndex = 25;
            pronc.TabStop = false;
            pronc.Text = "Pronouce";
            pronc.UseVisualStyleBackColor = true;
            pronc.Click += button1_Click;
            // 
            // Project3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(pronc);
            Controls.Add(TextNum);
            Controls.Add(Number);
            Controls.Add(lb_pronouce);
            Controls.Add(lb_inputnum);
            Controls.Add(bt_back);
            Name = "Project3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project3";
            Load += Project3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_back;
        private Label lb_inputnum;
        private Label lb_pronouce;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox Number;
        private TextBox TextNum;
        private Button pronc;
    }
}