using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LAB4
{
    public partial class BT4 : Form
    {
        public BT4()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (HttpClient client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password)
                });

                try
                {
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Xử lý khi đăng nhập thành công
                        var json = await response.Content.ReadAsStringAsync();
                        dynamic data = JsonConvert.DeserializeObject(json);
                        string tokenType = data.token_type;
                        string accessToken = data.access_token;
                        txtResult.Text = $"{tokenType} {accessToken}\nĐăng nhập thành công";
                    }
                    else
                    {
                        // Xử lý khi đăng nhập thất bại
                        var json = await response.Content.ReadAsStringAsync();
                        dynamic data = JsonConvert.DeserializeObject(json);
                        txtResult.Text = data.detail ?? "Đăng nhập thất bại";
                    }
                }
                catch (Exception ex)
                {
                    txtResult.Text = $"Đã xảy ra lỗi: {ex.Message}";
                }
            }
        }
    }
}
