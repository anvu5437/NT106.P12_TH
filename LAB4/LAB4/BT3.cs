using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;

namespace LAB4
{
    public partial class BT3 : Form
    {
        public BT3()
        {
            InitializeComponent();
        }

        //Chuyen huong toi trang web
        private void go_bt_Click(object sender, EventArgs e)
        {
            webView_bt3.Source = new Uri(ULR_tb.Text);
        }

        private async void ViewSouce_bt_Click(object sender, EventArgs e)
        {
            var htmlText = await webView_bt3.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML;");
            Source_bt3 source_Bt3 = new Source_bt3(htmlText);
            source_Bt3.Show();
        }

        //Dong form
        private void BT3_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private async void dlFile_bt_Click(object sender, EventArgs e)
        {
            // Lấy mã HTML của trang web
            var htmlContent = await webView_bt3.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML;");
            htmlContent = System.Text.RegularExpressions.Regex.Unescape(htmlContent.Trim('"'));

            // Phân tích HTML để tìm các URL tài nguyên
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument(); 
            document.LoadHtml(htmlContent);

            // Tạo thư mục lưu các tài nguyên tải xuống
            string downloadFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DownloadedResources");
            Directory.CreateDirectory(downloadFolderPath);

            // Tải hình ảnh
            var images = document.DocumentNode.SelectNodes("//img[@src]");
            if (images != null)
            {
                foreach (var img in images)
                {
                    string imgUrl = img.GetAttributeValue("src", "");
                    DownloadFile(imgUrl, downloadFolderPath);
                }
            }

            // Tải CSS
            var cssLinks = document.DocumentNode.SelectNodes("//link[@rel='stylesheet']");
            if (cssLinks != null)
            {
                foreach (var css in cssLinks)
                {
                    string cssUrl = css.GetAttributeValue("href", "");
                    DownloadFile(cssUrl, downloadFolderPath);
                }
            }

            // Tải JavaScript
            var scripts = document.DocumentNode.SelectNodes("//script[@src]");
            if (scripts != null)
            {
                foreach (var script in scripts)
                {
                    string jsUrl = script.GetAttributeValue("src", "");
                    DownloadFile(jsUrl, downloadFolderPath);
                }
            }

            MessageBox.Show("Tải tài nguyên thành công!", "Thông báo");
        }

        // Hàm tải file từ URL và lưu vào thư mục chỉ định
        private void DownloadFile(string url, string downloadFolderPath)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    // Giải mã URL trước khi tải
                    url = System.Web.HttpUtility.HtmlDecode(url);

                    // Xác định tên file và đường dẫn đầy đủ để lưu
                    string fileName = Path.GetFileName(url);
                    string filePath = Path.Combine(downloadFolderPath, fileName);

                    // Kiểm tra URL hợp lệ và tải file
                    if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                    {
                        client.DownloadFile(url, filePath);
                        MessageBox.Show($"Đã tải xuống tài nguyên thành công: {url}\nĐường dẫn lưu: {filePath}", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không tải được tài nguyên: {url}\nLỗi: {ex.Message}", "Lỗi");
            }
        }



        private async void dlHTML_bt_Click(object sender, EventArgs e)
        {
            var htmlText = await webView_bt3.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML;");
            // Xóa các ký tự JSON đặc biệt
            htmlText = System.Text.RegularExpressions.Regex.Unescape(htmlText.Trim('"'));

            // Lưu mã HTML vào file
            string htmlFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DownloadedPage.html");
            File.WriteAllText(htmlFilePath, htmlText);

            MessageBox.Show($"Mã HTML đã được lưu tại: {htmlFilePath}", "Thông báo");
        }


    }
}
