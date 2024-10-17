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
            this.UDPserverbtn = new System.Windows.Forms.Button();
            this.UDPClientbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UDPserverbtn
            // 
            this.UDPserverbtn.Location = new System.Drawing.Point(41, 24);
            this.UDPserverbtn.Name = "UDPserverbtn";
            this.UDPserverbtn.Size = new System.Drawing.Size(125, 37);
            this.UDPserverbtn.TabIndex = 0;
            this.UDPserverbtn.Text = "UDP Server";
            this.UDPserverbtn.UseVisualStyleBackColor = true;
            this.UDPserverbtn.Click += new System.EventHandler(this.UDPserverbtn_Click);
            // 
            // UDPClientbtn
            // 
            this.UDPClientbtn.Location = new System.Drawing.Point(329, 24);
            this.UDPClientbtn.Name = "UDPClientbtn";
            this.UDPClientbtn.Size = new System.Drawing.Size(125, 37);
            this.UDPClientbtn.TabIndex = 1;
            this.UDPClientbtn.Text = "UDP Client";
            this.UDPClientbtn.UseVisualStyleBackColor = true;
            this.UDPClientbtn.Click += new System.EventHandler(this.UDPClientbtn_Click);
            // 
            // BT1_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 88);
            this.Controls.Add(this.UDPClientbtn);
            this.Controls.Add(this.UDPserverbtn);
            this.Name = "BT1_Dashboard";
            this.Text = "BT1_Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UDPserverbtn;
        private System.Windows.Forms.Button UDPClientbtn;
    }
}