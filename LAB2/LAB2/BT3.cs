using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class BT3 : Form
    {
        public BT3()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Sử dụng OpenFileDialog để chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Chọn file input3.txt để đọc";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc nội dung từ file được chọn và hiển thị trong TextBox txtInput
                    string filePath = openFileDialog.FileName;
                    string[] lines = File.ReadAllLines(filePath);
                    txtInput.Lines = lines; // Hiển thị nội dung trong TextBox txtInput
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            // Sử dụng SaveFileDialog để chọn file output
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Chọn hoặc tạo file output để lưu kết quả";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đường dẫn đến file output đã chọn hoặc tạo
                    string outputFilePath = saveFileDialog.FileName;

                    // Đọc từng dòng từ TextBox txtInput
                    string[] lines = txtInput.Lines;
                    List<string> results = new List<string>();

                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line)) // Bỏ qua các dòng trống
                        {
                            double result = EvaluateExpression(line); // Tính toán biểu thức
                            results.Add($"{line} = {result}"); // Ghi kết quả dưới dạng: biểu thức = kết quả
                        }
                    }

                    // Ghi kết quả xuống file đã chọn trong SaveFileDialog
                    File.WriteAllLines(outputFilePath, results);
                    txtOutput.Lines = results.ToArray(); // Hiển thị kết quả trong TextBox txtOutput

                    MessageBox.Show("Ghi kết quả xuống file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
                }
            }
        }

        private double EvaluateExpression(string expression)
        {
            try
            {
                return Evaluate(expression);
            }
            catch
            {
                throw new Exception("Biểu thức không hợp lệ.");
            }
        }

        private double Evaluate(string expression)
        {
            var tokens = GetTokens(expression);
            var values = new Stack<double>();
            var operators = new Stack<char>();

            for (int i = 0; i < tokens.Count; i++)
            {
                string token = tokens[i];

                // Nếu là số, đẩy vào stack values
                if (double.TryParse(token, out double number))
                {
                    values.Push(number);
                }
                else if (token == "(")
                {
                    operators.Push('(');
                }
                else if (token == ")")
                {
                    // Đánh giá tất cả biểu thức trong dấu ngoặc
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
                    }
                    operators.Pop(); // Bỏ dấu ngoặc '('
                }
                else if (IsOperator(token))
                {
                    // Trong trường hợp gặp toán tử, đánh giá các toán tử có độ ưu tiên cao hơn
                    while (operators.Count > 0 && HasPrecedence(token[0], operators.Peek()))
                    {
                        values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
                    }
                    operators.Push(token[0]);
                }
            }

            // Áp dụng toán tử còn lại
            while (operators.Count > 0)
            {
                values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
            }

            // Giá trị cuối cùng trên stack values là kết quả
            return values.Pop();
        }

        // Hàm xác định độ ưu tiên của toán tử
        private bool HasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
                return false;
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                return false;
            else
                return true;
        }

        // Hàm kiểm tra ký tự có phải toán tử không
        private bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }

        // Hàm áp dụng toán tử cho 2 toán hạng
        private double ApplyOperation(char operation, double b, double a)
        {
            switch (operation)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/':
                    if (b == 0)
                        throw new DivideByZeroException("Không thể chia cho 0.");
                    return a / b;
                default: throw new InvalidOperationException("Toán tử không hợp lệ.");
            }
        }

        // Hàm tách biểu thức thành các token
        private List<string> GetTokens(string expression)
        {
            var tokens = new List<string>();
            var number = "";

            foreach (char c in expression)
            {
                if (char.IsDigit(c) || c == '.') // Nếu là số hoặc dấu chấm thập phân
                {
                    number += c;
                }
                else
                {
                    if (number != "")
                    {
                        tokens.Add(number);
                        number = "";
                    }

                    if (c == ' ')
                        continue;

                    tokens.Add(c.ToString());
                }
            }

            if (number != "")
                tokens.Add(number);

            return tokens;
        }
    }
}
