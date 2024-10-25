using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace LAB3
{
    public partial class BT5_Server : Form
    {
        private TcpListener server;
        private List<Button> seatButtons = new List<Button>();
        private int availableSeats = 25; // Ghế trống ban đầu
        private int connectedClients = 0; // Thiết bị kết nối
        private List<TcpClient> clients = new List<TcpClient>(); // Danh sách client

        public BT5_Server()
        {
            InitializeComponent();
            GenerateSeats(); // Tạo các ghế
        }

        // Tạo button ghế từ 1 đến 25
        private void GenerateSeats()
        {
            for (int i = 1; i <= 25; i++)
            {
                Button btn = new Button
                {
                    Text = i.ToString(),
                    Width = 60,
                    Height = 60,
                    BackColor = Color.Green, // Ghế trống có màu xanh lá
                    Name = "btnSeat" + i // Đặt tên cho nút để dễ nhận diện
                };
                seatButtons.Add(btn);
                flowLayoutPanelSeats.Controls.Add(btn); // Thêm vào FlowLayoutPanel
            }
        }

        // Khởi động server
        private void StartServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int port = int.Parse(txtPort.Text);
                server = new TcpListener(IPAddress.Any, port);
                server.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                server.Start();

                string serverIP = GetLocalIPAddress();
                txtServerIP.Text = serverIP;
                lblPort.Text = "Port: " + port;

                MessageBox.Show("Server đã được khởi động thành công trên IP: " + serverIP + " và cổng: " + port, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblConnectedClients.Text = "Thiết bị kết nối: " + connectedClients;

                // Chấp nhận kết nối client
                server.BeginAcceptTcpClient(new AsyncCallback(OnClientConnected), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể khởi động server: " + ex.Message);
            }
        }

        // Xử lý khi client kết nối
        private void OnClientConnected(IAsyncResult ar)
        {
            TcpClient client = server.EndAcceptTcpClient(ar);
            clients.Add(client);
            connectedClients++;
            UpdateConnectedClientsLabel();

            // Tiếp tục chấp nhận kết nối mới
            server.BeginAcceptTcpClient(new AsyncCallback(OnClientConnected), null);

            // Bắt đầu đọc dữ liệu từ client
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(OnDataReceived), new { Client = client, Buffer = buffer });
        }

        // Cập nhật nhãn hiển thị số thiết bị kết nối
        private void UpdateConnectedClientsLabel()
        {
            lblConnectedClients.Invoke(new Action(() =>
            {
                lblConnectedClients.Text = "Thiết bị kết nối: " + connectedClients;
            }));
        }

        // Xử lý dữ liệu nhận được từ client
        private void OnDataReceived(IAsyncResult ar)
        {
            dynamic state = ar.AsyncState;
            TcpClient client = state.Client;
            byte[] buffer = state.Buffer;

            try
            {
                NetworkStream stream = client.GetStream();
                int bytesRead = stream.EndRead(ar);

                if (bytesRead > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    HandleClientRequest(message, client);

                    // Tiếp tục đọc dữ liệu
                    stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(OnDataReceived), state);
                }
                else
                {
                    // Client ngắt kết nối
                    DisconnectClient(client);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu không thể đọc dữ liệu (có thể do client ngắt kết nối)
                DisconnectClient(client);
            }
        }

        private void DisconnectClient(TcpClient client)
        {
            if (clients.Contains(client))
            {
                clients.Remove(client);  // Xóa client khỏi danh sách
                connectedClients--;      // Giảm số lượng thiết bị kết nối
                UpdateConnectedClientsLabel();  // Cập nhật hiển thị số thiết bị kết nối
                client.Close();          // Đóng kết nối của client
            }
        }

        // Gửi trạng thái ghế tới tất cả client
        private void BroadcastSeatStatus(int seatNumber, string clientName)
        {
            // Xác định trạng thái ghế: 0 = trống, 1 = đã đặt
            int seatStatus = seatButtons[seatNumber - 1].BackColor == Color.Red ? 1 : 0;

            string message = $"Cập nhật;{seatNumber};{clientName};{seatStatus}";

            foreach (var client in clients)
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi gửi dữ liệu cho client: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DisconnectClient(client);
                }
            }
        }

        // Gửi thông điệp cho client
        private void SendMessageToClient(TcpClient client, string message)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi gửi dữ liệu tới client
                MessageBox.Show($"Lỗi gửi dữ liệu cho client: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý yêu cầu từ client
        private void HandleClientRequest(string message, TcpClient client)
        {
            // Kiểm tra nếu message là yêu cầu ngắt kết nối
            if (message == "Ngắt kết nối")
            {
                DisconnectClient(client);
                return;
            }

            // message có dạng "Đặt;ghế số;Tên"
            var parts = message.Split(';');
            if (parts.Length == 3 && parts[0] == "Đặt")
            {
                int seatNumber = int.Parse(parts[1]);
                string clientName = parts[2];

                // Đặt ghế và cập nhật màu sắc
                if (seatNumber >= 1 && seatNumber <= 25)
                {
                    // Kiểm tra ghế đã đặt chưa
                    if (seatButtons[seatNumber - 1].BackColor == Color.Green)
                    {
                        seatButtons[seatNumber - 1].BackColor = Color.Red; // Đổi màu ghế thành đỏ khi đặt
                        seatButtons[seatNumber - 1].Text = clientName; // Hiển thị tên client lên ghế

                        availableSeats--;
                        BroadcastSeatStatus(seatNumber, clientName); // Gửi thông tin ghế tới tất cả client
                        UpdateSeatCount(); // Cập nhật số ghế trống
                    }
                    else
                    {
                        // Nếu ghế đã được đặt, gửi thông báo lại cho client
                        SendMessageToClient(client, "Ghế đã được đặt!");
                    }
                }
            }
        }

        // Cập nhật số ghế trống
        private void UpdateSeatCount()
        {
            lblAvailableSeats.Invoke(new Action(() =>
            {
                lblAvailableSeats.Text = "Ghế trống: " + availableSeats;
            }));
        }

        // Lấy IP máy chủ
        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Không có adapter mạng nào có địa chỉ IPv4!");
        }

        // Dừng server và giải phóng tài nguyên
        private void StopServer()
        {
            if (server != null)
            {
                server.Stop();
                foreach (var client in clients)
                {
                    client.Close(); // Ngắt kết nối tất cả các client
                }
                clients.Clear();
                connectedClients = 0;
                UpdateConnectedClientsLabel();
                MessageBox.Show("Server đã ngừng hoạt động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BT5_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Xác nhận người dùng có thực sự muốn đóng form không
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng server?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StopServer();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void lblConnectedClients_Click(object sender, EventArgs e)
        {

        }

        private void BT5_Server_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
