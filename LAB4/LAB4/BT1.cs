using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }
        private void btn_Get_Click(object sender, EventArgs e)
        {
            string url = txt_Url.Text;
            bool isUri = Uri.IsWellFormedUriString(url, UriKind.Absolute);

            if (string.IsNullOrWhiteSpace(url) || !isUri)
            {
                txt_Url.Focus();
                MessageBox.Show("Url không đúng định dạng");
                return;
            }

            try
            {
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                rtxt_HTML.Text = reader.ReadToEnd();
                response.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txt_Url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Get_Click(this, new EventArgs());
        }

        private void BT1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}