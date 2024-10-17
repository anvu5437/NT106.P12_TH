using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LAB3
{
    public partial class BT4_Client : Form
    {
        TcpClient client;
        NetworkStream stream;

        public BT4_Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 8888);
                stream = client.GetStream();
                Log("Connected to server.");

                // Gửi tên client tới server
                byte[] buffer = Encoding.UTF8.GetBytes(txtName.Text);
                stream.Write(buffer, 0, buffer.Length);

                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                Log("Error: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client != null && stream != null)
            {
                string recipient = txtRecipient.Text; // Nhập tên người nhận
                string message = txtName.Text + ": " + txtMessage.Text;

                if (!string.IsNullOrEmpty(recipient))
                {
                    message = $"private:{recipient}:{message}"; // Định dạng tin nhắn riêng
                }

                byte[] buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
                txtMessage.Clear();
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int byteCount;

            while ((byteCount = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, byteCount);
                Log(message);
            }
        }

        private void Log(string message)
        {
            Invoke((MethodInvoker)delegate
            {
                txtChat.AppendText(message + Environment.NewLine);
            });
        }
    }
}
