namespace LAB4
{
    partial class Source_bt3
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
            source_tb = new TextBox();
            SuspendLayout();
            // 
            // source_tb
            // 
            source_tb.Location = new Point(12, 12);
            source_tb.Multiline = true;
            source_tb.Name = "source_tb";
            source_tb.ScrollBars = ScrollBars.Vertical;
            source_tb.Size = new Size(776, 426);
            source_tb.TabIndex = 0;
            // 
            // Source_bt3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(source_tb);
            Name = "Source_bt3";
            Text = "Source_bt3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox source_tb;
    }
}