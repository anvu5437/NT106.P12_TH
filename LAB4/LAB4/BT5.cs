using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LAB4
{
    public partial class BT5 : Form
    {
        public BT5()
        {
            InitializeComponent();
        }

        private async void btnGetUserInfo_Click(object sender, EventArgs e)
        {
            string url = "https://nt106.uitiot.vn/api/v1/user/me";
            string token = txtToken.Text; // Token nhận được từ bài 4 (được lưu trong TextBox)

            using (HttpClient client = new HttpClient())
            {
                // Thêm JWT token vào header
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                try
                {
                    // Gửi yêu cầu GET tới API
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        // Xử lý khi thành công
                        var json = await response.Content.ReadAsStringAsync();
                        dynamic data = JsonConvert.DeserializeObject(json);

                        // Giả sử API trả về các thông tin user như name, email, v.v.
                        string username = data.username;
                        string email = data.email;
                        string fullName = data.full_name;

                        // Hiển thị thông tin người dùng lên giao diện
                        txtResult.Text = $"Tên: {fullName}\nEmail: {email}\nUsername: {username}";
                    }
                    else
                    {
                        // Xử lý khi yêu cầu không thành công
                        var json = await response.Content.ReadAsStringAsync();
                        dynamic data = JsonConvert.DeserializeObject(json);
                        txtResult.Text = $"Lỗi: {data.detail ?? "Không thể lấy thông tin người dùng"}";
                    }
                }
                catch (Exception ex)
                {
                    txtResult.Text = $"Đã xảy ra lỗi: {ex.Message}";
                }
            }
        }

        private void BT5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
