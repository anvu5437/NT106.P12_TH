using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LAB3
{
    public partial class BT4_Server : Form
    {
        TcpListener listener;
        List<TcpClient> clients;
        List<string> clientNames; // Danh sách tên client

        public BT4_Server()
        {
            InitializeComponent();
            clients = new List<TcpClient>();
            clientNames = new List<string>(); // Khởi tạo danh sách tên client
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(StartServer);
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void StartServer()
        {
            listener = new TcpListener(IPAddress.Any, 8888);
            listener.Start();
            Log("Server started...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                clients.Add(client);
                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.IsBackground = true;
                clientThread.Start();
            }
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int byteCount;

            // Nhận tên client
            byteCount = stream.Read(buffer, 0, buffer.Length);
            string clientName = Encoding.UTF8.GetString(buffer, 0, byteCount);
            clientNames.Add(clientName);
            Log(clientName + " đã kết nối.");

            while ((byteCount = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, byteCount);
                Log(message);
                // Kiểm tra nếu tin nhắn bắt đầu bằng "private:"
                if (message.StartsWith("private:"))
                {
                    string[] parts = message.Split(new[] { ':' }, 3);
                    if (parts.Length == 3)
                    {
                        string recipient = parts[1].Trim();
                        string privateMessage = parts[2].Trim();
                        SendPrivateMessage(recipient, privateMessage, client);
                    }
                }
                else
                {
                    BroadcastMessage(message, client);
                }
            }
        }

        private void SendPrivateMessage(string recipient, string message, TcpClient sender)
        {
            int recipientIndex = clientNames.IndexOf(recipient);
            if (recipientIndex >= 0 && recipientIndex < clients.Count)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                NetworkStream stream = clients[recipientIndex].GetStream();
                stream.Write(buffer, 0, buffer.Length);
                Log($"Gửi tin nhắn riêng cho {recipient}: {message}");
            }
        }

        private void BroadcastMessage(string message, TcpClient excludeClient)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);

            foreach (TcpClient client in clients)
            {
                if (client != excludeClient)
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        private void Log(string message)
        {
            Invoke((MethodInvoker)delegate
            {
                txtLogs.AppendText(message + Environment.NewLine);
            });
        }
    }
}
