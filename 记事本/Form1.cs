using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本
{
    public partial class Form1 : Form
    {
        public static Form1 f1;
        public Form1()
        {
            InitializeComponent();
            f1 = this;
        }

        private void 格式ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = "";
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.CanUndo)
            {
                this.richTextBox1.Undo();
            }
        }

        private void 新窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f11 = new Form1();
            f11.Show();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt|RTF文件(*.RTF)|*.rtf|所有文件(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.RestoreDirectory = true;
            string FileName = openFileDialog1.FileName;

            if (FileName!="")
            {
                if (openFileDialog1.FilterIndex == 1)
                {
                    f1.richTextBox1.LoadFile(FileName, RichTextBoxStreamType.PlainText);
                }
                else if (openFileDialog1.FilterIndex == 2)
                {
                    f1.richTextBox1.LoadFile(FileName, RichTextBoxStreamType.RichText);
                }
                else
                    MessageBox.Show("请选择有效的文件类型打开！！");
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|RTF文件(*.RTF)|*.rtf|所有文件(*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            
           
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string FileName = saveFileDialog1.FileName;
                if (saveFileDialog1.FilterIndex == 1)
                    f1.richTextBox1.SaveFile(FileName, RichTextBoxStreamType.PlainText);
                else if (saveFileDialog1.FilterIndex == 2)
                    f1.richTextBox1.SaveFile(FileName, RichTextBoxStreamType.RichText);
                else
                    MessageBox.Show("未知类型！");
            }
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|RTF文件(*.RTF)|*.rtf|所有文件(*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.InitialDirectory = Application.StartupPath;

           
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = saveFileDialog1.FileName;
                if (saveFileDialog1.FilterIndex == 1)
                    f1.richTextBox1.SaveFile(FileName, RichTextBoxStreamType.PlainText);
                else if (saveFileDialog1.FilterIndex == 2)
                    f1.richTextBox1.SaveFile(FileName, RichTextBoxStreamType.RichText);
                else
                    MessageBox.Show("未知类型！");
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.richTextBox1.Cut();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.richTextBox1.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.richTextBox1.Paste();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.richTextBox1.SelectedText="";
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

       

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.richTextBox1.SelectAll();
        }

        private void 时间日期ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.richTextBox1.Text += DateTime.Now.ToString("yyyy-mm-dd");
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Multiline = false;
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            colorDialog1.ShowDialog();
        }

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusStrip1.Enabled)
            {
                statusStrip1.Enabled = false;
                statusStrip1.Hide();
            }
            else
            {
                statusStrip1.Enabled = true;
                statusStrip1.Show();
            }

        }


        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "字符数："+richTextBox1.Text.Length.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss");
        }

    }
}
