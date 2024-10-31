using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace LAB3
{
    public partial class BT5_Client : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private int selectedSeatNumber = -1;

        public BT5_Client()
        {
            InitializeComponent();
            CreateSeatButtons();
        }

        //Tạo nút ghế
        private void CreateSeatButtons()
        {
            for (int i = 1; i <= 25; i++) // Giả sử có 25 ghế
            {
                Button seatButton = new Button
                {
                    Name = $"btnSeat{i}",
                    Text = i.ToString(),
                    Size = new Size(60, 60),
                    BackColor = Color.Green, // Màu ghế trống
                    Tag = i // Lưu số ghế vào thuộc tính Tag
                };

                seatButton.Click += SeatButton_Click; // Đăng ký sự kiện click cho nút ghế
                flowLayoutPanelSeats.Controls.Add(seatButton); // Thêm nút ghế vào FlowLayoutPanel
            }
        }

        //Kết nối với Server
        private void ConnectToServer(string ip, int port)
        {
            try
            {
                client = new TcpClient(ip, port);
                stream = client.GetStream();
                BeginRead(); // Bắt đầu đọc dữ liệu từ server
                MessageBox.Show("Kết nối đến server thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string ip = txtServerIP.Text;
            string clientName = txtClientName.Text.Trim(); // Lấy tên người dùng và xóa khoảng trắng

            if (string.IsNullOrEmpty(clientName)) // Kiểm tra tên người dùng
            {
                MessageBox.Show("Vui lòng nhập tên người dùng để kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txtPort.Text, out int port))
            {
                ConnectToServer(ip, port);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin máy chủ hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Nhận Dữ Liệu từ Server
        private void BeginRead()
        {
            try
            {
                byte[] buffer = new byte[1024];
                stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(OnDataReceived), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi bắt đầu đọc dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnDataReceived(IAsyncResult ar)
        {
            try
            {
                byte[] buffer = (byte[])ar.AsyncState;
                int bytesRead = stream.EndRead(ar);

                if (bytesRead > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Invoke((Action)(() => HandleServerMessage(message)));
                    Invoke((Action)(() => OnDataReceivedFromServer(message)));
                }
                BeginRead();
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Kết nối với server đã bị ngắt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nhận dữ liệu từ server: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleServerMessage(string message)
        {
            var parts = message.Split(';');

            if (parts[0] == "Cập nhật")
            {
                int seatNumber = int.Parse(parts[1]);
                string clientName = parts[2];
                UpdateSeatStatus(seatNumber, "Đỏ", clientName);
            }
            else if (message == "Ghế đã được đặt!")
            {
                MessageBox.Show("Ghế đã được đặt! Vui lòng chọn ghế khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (parts[0] == "Trạng thái ghế")
            {
                for (int i = 1; i < parts.Length; i += 3)
                {
                    int seatNumber = int.Parse(parts[i]);
                    string seatStatus = parts[i + 1];
                    string clientName = parts[i + 2]; // Lấy tên người đã đặt
                    UpdateSeatStatus(seatNumber, seatStatus, clientName); // Cập nhật trạng thái cho từng ghế
                }
            }
        }

        private void OnDataReceivedFromServer(string message)
        {
            var parts = message.Split(';');
            if (parts.Length == 4 && parts[0] == "Cập nhật")
            {
                int seatNumber = int.Parse(parts[1]);
                string clientName = parts[2];
                int seatStatus = int.Parse(parts[3]); // Trạng thái ghế từ server (0 hoặc 1)

                // Tìm button tương ứng với số ghế
                Button seatButton = flowLayoutPanelSeats.Controls[seatNumber - 1] as Button;

                // Cập nhật màu ghế dựa trên trạng thái
                if (seatStatus == 0)
                {
                    seatButton.BackColor = Color.Green;
                    seatButton.Text = "";
                }
                else if (seatStatus == 1)
                {
                    seatButton.BackColor = Color.Red;
                    seatButton.Text = clientName;
                }
            }
        }

        //Cập nhật trạng thái ghế
        private void UpdateSeatStatus(int seatNumber, string seatStatus, string clientName = "")
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int, string, string>(UpdateSeatStatus), seatNumber, seatStatus, clientName);
                return;
            }

            var seatButton = flowLayoutPanelSeats.Controls[seatNumber - 1] as Button;

            switch (seatStatus)
            {
                case "Đỏ": // Ghế đã đặt
                    seatButton.BackColor = Color.Red;
                    seatButton.Enabled = false;
                    //seatButton.Text += $"\n({clientName})";
                    break;
                case "Xanh": // Ghế trống
                    seatButton.BackColor = Color.Green;
                    seatButton.Enabled = true;
                    seatButton.Text = seatNumber.ToString();
                    break;
                case "Vàng":
                    seatButton.BackColor = Color.Yellow;
                    seatButton.Enabled = true;
                    break;
            }
        }

        //Sự kiện nhấn nút đặt và chọn ghế
        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (sender is Button seatButton)
            {
                // Nếu ghế đã đặt (màu đỏ), hiển thị thông báo và không cho phép chọn
                if (seatButton.BackColor == Color.Red)
                {
                    MessageBox.Show("Ghế này đã được đặt. Vui lòng chọn ghế khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Đặt lại màu ghế trước đó nếu đã chọn ghế
                if (selectedSeatNumber != -1)
                {
                    var previousSeatButton = flowLayoutPanelSeats.Controls[selectedSeatNumber - 1] as Button;
                    previousSeatButton.BackColor = Color.Green; // Đổi màu ghế về xanh
                    previousSeatButton.Text = previousSeatButton.Tag.ToString(); // Hiển thị lại số ghế
                }

                // Cập nhật số ghế được chọn
                selectedSeatNumber = (int)seatButton.Tag; // Lấy số ghế từ thuộc tính Tag
                seatButton.BackColor = Color.Yellow; // Đổi màu ghế thành vàng khi chọn
                seatButton.Text = ""; // Ẩn số ghế khi chọn
                MessageBox.Show($"Bạn đã chọn ghế số {selectedSeatNumber}.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            if (selectedSeatNumber != -1 && selectedSeatNumber <= 25)
            {
                string clientName = txtClientName.Text.Trim(); // Lấy tên người dùng và xóa khoảng trắng

                if (string.IsNullOrEmpty(clientName)) // Kiểm tra tên người dùng
                {
                    MessageBox.Show("Vui lòng nhập tên người dùng để kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Gửi yêu cầu đặt ghế tới server
                    string message = $"Đặt;{selectedSeatNumber};{clientName}";
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi gửi yêu cầu đặt ghế: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ghế hợp lệ trước khi đặt.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        //Hàm xử lý ngắt kết nối và đóng form client
        private void DisconnectClient()
        {
            try
            {
                // Gửi yêu cầu ngắt kết nối tới server
                if (client != null && client.Connected)
                {
                    NetworkStream stream = client.GetStream();
                    byte[] data = Encoding.UTF8.GetBytes("Ngắt kết nối");
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ngắt kết nối: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối socket của client
                if (client != null)
                {
                    client.Close();
                    client = null;
                }
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Xác nhận người dùng có thực sự muốn ngắt kết nối client không
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn ngắt kết nối client?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DisconnectClient();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void flowLayoutPanelSeats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtServerIP_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
        }

        private void BT5_Client_Load(object sender, EventArgs e)
        {

        }

        private void txtServerIP_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
