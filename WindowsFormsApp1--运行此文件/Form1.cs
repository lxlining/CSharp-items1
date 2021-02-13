using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sname = Application.StartupPath;
        private void 随机出题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string filename=sname+ "\\..\\..\\..\\随机出题\\bin\\Debug\\WindowsFormsApp1.exe";
            System.Diagnostics.Process.Start(filename);
        }

        private void 双色球福利彩票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = sname + "\\..\\..\\..\\双色球\\bin\\Debug\\WindowsFormsApp2.exe";
            System.Diagnostics.Process.Start(filename);
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = sname + "\\..\\..\\..\\计算器\\bin\\Debug\\WindowsFormsApp3.exe";
            System.Diagnostics.Process.Start(filename);
        }

        private void 评委打分ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = sname + "\\..\\..\\..\\评委打分\\评委打分\\bin\\Debug\\评委打分.exe";
            System.Diagnostics.Process.Start(filename);
        }

        private void 联动选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = sname + "\\..\\..\\..\\联动选课\\bin\\Debug\\WindowsFormsApp3.exe";
            System.Diagnostics.Process.Start(filename);
        }

        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = sname + "\\..\\..\\..\\记事本\\bin\\Debug\\记事本.exe";
            System.Diagnostics.Process.Start(filename);
        }

        private void 图片浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = sname + "\\..\\..\\..\\图片播放\\bin\\Debug\\WindowsFormsApp5.exe";
            System.Diagnostics.Process.Start(filename);
        }

        private void 随机点名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = sname + "\\..\\..\\..\\点名\\bin\\Debug\\WindowsFormsApp6.exe";
            System.Diagnostics.Process.Start(filename);
        }
    }
}
