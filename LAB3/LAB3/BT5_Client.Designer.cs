namespace LAB3
{
    partial class BT5_Client
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSeats;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnConnect;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            flowLayoutPanelSeats = new FlowLayoutPanel();
            txtClientName = new TextBox();
            txtPort = new TextBox();
            btnReserve = new Button();
            btnConnect = new Button();
            lb_username = new Label();
            lb_port = new Label();
            ld_ipserver = new Label();
            txtServerIP = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanelSeats
            // 
            flowLayoutPanelSeats.Location = new Point(278, 12);
            flowLayoutPanelSeats.Name = "flowLayoutPanelSeats";
            flowLayoutPanelSeats.Size = new Size(346, 326);
            flowLayoutPanelSeats.TabIndex = 0;
            flowLayoutPanelSeats.Paint += flowLayoutPanelSeats_Paint;
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(154, 98);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(100, 27);
            txtClientName.TabIndex = 1;
            txtClientName.TextChanged += txtClientName_TextChanged;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(154, 53);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 27);
            txtPort.TabIndex = 3;
            txtPort.TextChanged += txtPort_TextChanged;
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(399, 344);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(100, 33);
            btnReserve.TabIndex = 4;
            btnReserve.Text = "Đặt vé";
            btnReserve.UseVisualStyleBackColor = true;
            btnReserve.Click += BtnReserve_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(154, 143);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(100, 35);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Kết nối";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += ConnectButton_Click;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_username.Location = new Point(14, 101);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(121, 20);
            lb_username.TabIndex = 8;
            lb_username.Text = "Tên người dùng:";
            lb_username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_port
            // 
            lb_port.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_port.Location = new Point(12, 53);
            lb_port.Name = "lb_port";
            lb_port.Size = new Size(123, 26);
            lb_port.TabIndex = 9;
            lb_port.Text = "Port:";
            lb_port.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ld_ipserver
            // 
            ld_ipserver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ld_ipserver.Location = new Point(12, 12);
            ld_ipserver.Name = "ld_ipserver";
            ld_ipserver.Size = new Size(123, 27);
            ld_ipserver.TabIndex = 11;
            ld_ipserver.Text = "IP Server:";
            ld_ipserver.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(154, 12);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(100, 27);
            txtServerIP.TabIndex = 10;
            txtServerIP.TextChanged += txtServerIP_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 219);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 12;
            label1.Text = "Đang chọn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 318);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 13;
            label2.Text = "Ghế đã đặt:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 269);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 14;
            label3.Text = "Ghế trống:";
            // 
            // label4
            // 
            label4.BackColor = Color.Red;
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(154, 318);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 15;
            // 
            // label5
            // 
            label5.BackColor = Color.Yellow;
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(154, 219);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 16;
            // 
            // label6
            // 
            label6.BackColor = Color.Green;
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(154, 269);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 17;
            // 
            // BT5_Client
            // 
            ClientSize = new Size(634, 383);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ld_ipserver);
            Controls.Add(txtServerIP);
            Controls.Add(lb_port);
            Controls.Add(lb_username);
            Controls.Add(btnConnect);
            Controls.Add(btnReserve);
            Controls.Add(txtPort);
            Controls.Add(txtClientName);
            Controls.Add(flowLayoutPanelSeats);
            Name = "BT5_Client";
            Text = "Đặt vé Client";
            FormClosing += ClientForm_FormClosing;
            Load += BT5_Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lb_username;
        private Label lb_port;
        private Label ld_ipserver;
        private TextBox txtServerIP;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}