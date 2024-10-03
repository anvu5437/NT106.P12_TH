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
    public partial class BT5 : Form
    {

        public BT5()
        {
            InitializeComponent();
            LoadDrives();
            treeView1.NodeMouseClick += TreeView1_NodeMouseClick;
        }

        private void LoadDrives()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    TreeNode node = new TreeNode(drive.Name);
                    node.Tag = drive.RootDirectory;
                    treeView1.Nodes.Add(node);
                    LoadDirectories(node);
                }
            }
        }

        private void LoadDirectories(TreeNode node)
        {
            DirectoryInfo directory = (DirectoryInfo)node.Tag;

            try
            {
                foreach (var dir in directory.GetDirectories())
                {
                    TreeNode childNode = new TreeNode(dir.Name);
                    childNode.Tag = dir;
                    node.Nodes.Add(childNode);
                    LoadDirectories(childNode); // Đệ quy để tải các thư mục con
                }

                foreach (var file in directory.GetFiles())
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file;
                    node.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Không có quyền truy cập vào thư mục
            }
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is FileInfo fileInfo)
            {
                DisplayFileContent(fileInfo);
            }
            else if (e.Node.Tag is DirectoryInfo)
            {
                // Chọn thư mục
                richTextBox1.Clear();
                pictureBox1.Image = null; // Xóa hình ảnh trước
            }
        }

        private void DisplayFileContent(FileInfo fileInfo)
        {
            string extension = fileInfo.Extension.ToLower();

            if (extension == ".txt")
            {
                // Đọc nội dung file văn bản
                using (StreamReader sr = new StreamReader(fileInfo.FullName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
                pictureBox1.Image = null; // Xóa hình ảnh
            }
            else if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
            {
                // Hiển thị hình ảnh
                pictureBox1.Image = Image.FromFile(fileInfo.FullName);
                richTextBox1.Clear(); // Xóa nội dung văn bản
            }
            else
            {
                richTextBox1.Clear();
                pictureBox1.Image = null; // Xóa hình ảnh
                MessageBox.Show("Chỉ hỗ trợ file văn bản và hình ảnh!");
            }
        }
    }
}
