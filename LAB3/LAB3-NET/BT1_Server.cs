using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace LAB3
{
    public partial class BT1_Server : Form
    {
        private UdpClient udpServer;
        private Thread serverThread;
        public BT1_Server()
        {
            InitializeComponent();
        }

        private void ListenBtn_Click(object sender, EventArgs e)
        {
            int port = int.Parse(Porttxt.Text);
            udpServer = new UdpClient(port);
            serverThread = new Thread(new ThreadStart(ServerThread));
            serverThread.IsBackground = true;
            serverThread.Start();
            ListenBtn.Enabled = false;
        }

        private void ServerThread()
        {
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                byte[] data = udpServer.Receive(ref remoteEP);
                string message = Encoding.UTF8.GetString(data);
                ShowMessage($"{remoteEP.Address}:{message}");
            }
        }

        private void ShowMessage(string message)
        {
            if (lstMessages.InvokeRequired)
            {
                lstMessages.Invoke(new Action(() => lstMessages.Items.Add(message)));
            }
            else
            {
                lstMessages.Items.Add(message);
            }
        }
    }
}
