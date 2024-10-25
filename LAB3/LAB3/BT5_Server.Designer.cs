using System.Windows.Forms;

namespace LAB3
{
    partial class BT5_Server
    {
        private Button btnStartServer;
        private TextBox txtPort;
        private TextBox txtServerIP;
        private Label lblServerIP;
        private Label lblPort;
        private Label lblSelectedSeats;
        private Label lblAvailableSeats;
        private Label lblConnectedClients;
        private FlowLayoutPanel flowLayoutPanelSeats;

        private void InitializeComponent()
        {
            btnStartServer = new Button();
            txtPort = new TextBox();
            txtServerIP = new TextBox();
            lblServerIP = new Label();
            lblPort = new Label();
            lblSelectedSeats = new Label();
            lblAvailableSeats = new Label();
            lblConnectedClients = new Label();
            flowLayoutPanelSeats = new FlowLayoutPanel();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnStartServer
            // 
            btnStartServer.Location = new Point(341, 20);
            btnStartServer.Margin = new Padding(2, 3, 2, 3);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(68, 27);
            btnStartServer.TabIndex = 0;
            btnStartServer.Text = "Chạy";
            btnStartServer.Click += StartServerButton_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(256, 20);
            txtPort.Margin = new Padding(2, 3, 2, 3);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(81, 27);
            txtPort.TabIndex = 1;
            txtPort.Text = "8080";
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(80, 20);
            txtServerIP.Margin = new Padding(2, 3, 2, 3);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.ReadOnly = true;
            txtServerIP.Size = new Size(113, 27);
            txtServerIP.TabIndex = 2;
            // 
            // lblServerIP
            // 
            lblServerIP.Location = new Point(16, 20);
            lblServerIP.Margin = new Padding(2, 0, 2, 0);
            lblServerIP.Name = "lblServerIP";
            lblServerIP.Size = new Size(64, 20);
            lblServerIP.TabIndex = 3;
            lblServerIP.Text = "Server IP:";
            // 
            // lblPort
            // 
            lblPort.Location = new Point(216, 20);
            lblPort.Margin = new Padding(2, 0, 2, 0);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(40, 20);
            lblPort.TabIndex = 4;
            lblPort.Text = "Port:";
            // 
            // lblSelectedSeats
            // 
            lblSelectedSeats.Location = new Point(0, 0);
            lblSelectedSeats.Name = "lblSelectedSeats";
            lblSelectedSeats.Size = new Size(100, 23);
            lblSelectedSeats.TabIndex = 0;
            // 
            // lblAvailableSeats
            // 
            lblAvailableSeats.Location = new Point(16, 59);
            lblAvailableSeats.Margin = new Padding(2, 0, 2, 0);
            lblAvailableSeats.Name = "lblAvailableSeats";
            lblAvailableSeats.Size = new Size(160, 20);
            lblAvailableSeats.TabIndex = 5;
            lblAvailableSeats.Text = "Ghế trống: 25";
            // 
            // lblConnectedClients
            // 
            lblConnectedClients.Location = new Point(216, 59);
            lblConnectedClients.Margin = new Padding(2, 0, 2, 0);
            lblConnectedClients.Name = "lblConnectedClients";
            lblConnectedClients.Size = new Size(160, 20);
            lblConnectedClients.TabIndex = 6;
            lblConnectedClients.Text = "Thiết bị kết nối: 0";
            lblConnectedClients.Click += lblConnectedClients_Click;
            // 
            // flowLayoutPanelSeats
            // 
            flowLayoutPanelSeats.Location = new Point(16, 144);
            flowLayoutPanelSeats.Margin = new Padding(2, 3, 2, 3);
            flowLayoutPanelSeats.Name = "flowLayoutPanelSeats";
            flowLayoutPanelSeats.Size = new Size(393, 334);
            flowLayoutPanelSeats.TabIndex = 7;
            // 
            // label6
            // 
            label6.BackColor = Color.Green;
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(104, 98);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 21;
            // 
            // label4
            // 
            label4.BackColor = Color.Red;
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(309, 98);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 98);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 19;
            label3.Text = "Ghế trống:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(216, 98);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 18;
            label2.Text = "Ghế đã đặt:";
            label2.Click += label2_Click;
            // 
            // BT5_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 490);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnStartServer);
            Controls.Add(txtPort);
            Controls.Add(txtServerIP);
            Controls.Add(lblServerIP);
            Controls.Add(lblPort);
            Controls.Add(lblAvailableSeats);
            Controls.Add(lblConnectedClients);
            Controls.Add(flowLayoutPanelSeats);
            Margin = new Padding(2, 3, 2, 3);
            Name = "BT5_Server";
            Text = "Server";
            FormClosing += BT5_Server_FormClosing;
            Load += BT5_Server_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
