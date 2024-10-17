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

namespace LAB3
{
    public partial class BT1_Client : Form
    {
        private UdpClient udpClient;

        public BT1_Client()
        {
            InitializeComponent();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string ip = txtIP.Text;
            int port = int.Parse(txtPort.Text);
            string message = txtMessage.Text;

            udpClient = new UdpClient();
            byte[] data = Encoding.UTF8.GetBytes(message);
            udpClient.Send(data, data.Length, ip, port);
        }
    }
}
