namespace LAB3
{
    partial class BT1_Dashboard
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
            UDPserverbtn = new Button();
            UDPClientbtn = new Button();
            Backbtn = new Button();
            SuspendLayout();
            // 
            // UDPserverbtn
            // 
            UDPserverbtn.Location = new Point(41, 51);
            UDPserverbtn.Margin = new Padding(3, 4, 3, 4);
            UDPserverbtn.Name = "UDPserverbtn";
            UDPserverbtn.Size = new Size(125, 46);
            UDPserverbtn.TabIndex = 0;
            UDPserverbtn.Text = "UDP Server";
            UDPserverbtn.UseVisualStyleBackColor = true;
            UDPserverbtn.Click += UDPserverbtn_Click;
            // 
            // UDPClientbtn
            // 
            UDPClientbtn.Location = new Point(331, 51);
            UDPClientbtn.Margin = new Padding(3, 4, 3, 4);
            UDPClientbtn.Name = "UDPClientbtn";
            UDPClientbtn.Size = new Size(125, 46);
            UDPClientbtn.TabIndex = 1;
            UDPClientbtn.Text = "UDP Client";
            UDPClientbtn.UseVisualStyleBackColor = true;
            UDPClientbtn.Click += UDPClientbtn_Click;
            // 
            // Backbtn
            // 
            Backbtn.Location = new Point(12, 12);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(76, 32);
            Backbtn.TabIndex = 2;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // BT1_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 110);
            Controls.Add(Backbtn);
            Controls.Add(UDPClientbtn);
            Controls.Add(UDPserverbtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BT1_Dashboard";
            Text = "BT1_Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button UDPserverbtn;
        private System.Windows.Forms.Button UDPClientbtn;
        private Button Backbtn;
    }
}